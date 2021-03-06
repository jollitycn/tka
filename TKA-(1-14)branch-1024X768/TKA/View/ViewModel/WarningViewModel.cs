﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using TKA.Business;
using System.Threading;
using System.Windows;
using TKA.Model;

namespace TKA.ViewModel
{
    public class WarningViewModel : ViewModelBase
    {
        private Access accessin;
        private Queue<string> msgQueue = new Queue<string>();

        public WarningViewModel(ConfigModel CM)
        {
            accessin = new Access();

            for (int i = 0; i < CM.LTM.Count; i++)
            {
                TrackWarningViewModel twvm = new TrackWarningViewModel();
                twvm.TrackNum = int.Parse(CM.LTM[i].TrackID);
                TWVM.Add(twvm);
            }

            Thread thread = new Thread(new ThreadStart(() =>
            {
                string Msg = String.Empty;
                while (true)
                {
                    if (msgQueue != null && msgQueue.Count != 0)
                    {
                        Msg = msgQueue.Dequeue();
                    }
                    else
                    {
                        continue;
                    }

                    SpeechSynthesizer synth = new SpeechSynthesizer();

                    if (PLCControler.Instence.MWVM.CanSpeek)
                    {
                        PLCControler.Instence.SetChannel(PLCControler.Instence.MWVM.CM.SpeekAddress);
                    }

                    synth.Speak(Msg);
                    synth.Speak(Msg);

                    PLCControler.Instence.ReSetChannel(PLCControler.Instence.MWVM.CM.SpeekAddress);

                    Thread.Sleep(500);
                }
            }));
            thread.IsBackground = true;
            thread.Start();
        }

        public void SetWarning(Notification notification)
        {
            if (Application.Current != null)
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    IsWarning = notification.IsWarning;
                    WarningDataTime = notification.DateTime;
                    WarningText = notification.TrackNumber.ToString() + notification.NotifyInfo;

                    if (notification.NeedSpeech)
                    {
                        msgQueue.Enqueue(WarningText);
                    }

                    accessin.InsertWarning(WarningDataTime, WarningText);
                }));
            }
        }

        public void SetLastWarning(Notification notification)
        {
            if (Application.Current != null)
            {
                Application.Current.Dispatcher.Invoke(new Action(() =>
                {
                    if (notification == null)
                    {
                        WarningDataTime = "";
                        WarningText = "";
                    }
                    else
                    {
                        IsWarning = notification.IsWarning;
                        WarningDataTime = notification.DateTime;
                        WarningText = notification.TrackNumber.ToString() + notification.NotifyInfo;
                    }
                }));
            }
        }

        public List<TrackWarningViewModel> TWVM = new List<TrackWarningViewModel>();

        private bool m_IsWarning = false;
        /// <summary>
        /// 是否为警告
        /// </summary>
        public bool IsWarning
        {
            get
            {
                return m_IsWarning;
            }
            set
            {
                if (value != m_IsWarning)
                {
                    m_IsWarning = value;
                    RaisePropertyChanged(() => IsWarning);
                }
            }
        }

        private string m_WarningDataTime = "";
        /// <summary>
        /// 警告时间
        /// </summary>
        public string WarningDataTime
        {
            get
            {
                return m_WarningDataTime;
            }
            set
            {
                if (value != m_WarningDataTime)
                {
                    m_WarningDataTime = value;
                    RaisePropertyChanged(() => WarningDataTime);
                }
            }
        }

        private string m_WarningText = "";
        /// <summary>
        /// 警告文字
        /// </summary>
        public string WarningText
        {
            get
            {
                return m_WarningText;
            }
            set
            {
                if (value != m_WarningText)
                {
                    m_WarningText = value;
                    RaisePropertyChanged(() => WarningText);
                }
            }
        }

        #region Handle Notification
        /// <summary>
        /// record all notifications 
        /// </summary>
        private List<Notification> _NotificationList = new List<Notification>();

        /// <summary>
        /// add a notification to record list
        /// </summary>
        public void AddNotification(Notification notification)
        {
            if (_NotificationList == null)
                return;

            _NotificationList.Add(notification);
        }

        /// <summary>
        /// remove specific notification
        /// </summary>
        public void RemoveNotification(string notifyinfo, int trackNumber)
        {
            int index = -1;
            if (_NotificationList == null || _NotificationList.Count == 0)
                return;

            for (int i = 0; i < _NotificationList.Count; i++)
            {
                if (_NotificationList[i].NotifyInfo.Equals(notifyinfo) && _NotificationList[i].TrackNumber == trackNumber)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                _NotificationList.RemoveAt(index);
            }
        }

        /// <summary>
        /// decide wether current notification is the lastest
        /// </summary>
        private bool IsLatestNotification(string notifyinfo)
        {
            int index = 0;

            if (_NotificationList.Count == 0)
            {
                return false;
            }

            foreach (Notification item in _NotificationList)
            {
                index++;
                if (item.NotifyInfo.Equals(notifyinfo))
                {
                    break;
                }
            }

            if (index == _NotificationList.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// get the last notification from notification list
        /// </summary>
        public Notification GetlastNtification()
        {
            Notification lastNotification = new Notification();

            if (_NotificationList == null)
            {
                return null;
            }

            if (_NotificationList.Count != 0)
            {
                lastNotification = _NotificationList[_NotificationList.Count - 1];
            }
            else
            {
                lastNotification = null;
            }

            return lastNotification;
        }

        /// <summary>
        /// Notification Object
        /// </summary>
        public class Notification
        {
            public bool NeedSpeech { get; set; }
            public bool IsWarning { get; set; }
            public int TrackNumber { get; set; }
            public string NotifyInfo { get; set; }
            public string DateTime { get; set; }
        }

        #endregion
    }
}
