using System;
using System.Runtime.InteropServices;

namespace TKA
{
    class PlayCtrl_X86
    {
        public PlayCtrl_X86()
        {
            //
            // TODO: 
            //
        }

        public const string PLAYM4_API = "extern \"C\"__declspec(dllexport)";

        // public const string PLAYM4_API = "extern \"C\" __declspec(dllimport)";

        //Max channel numbers
        public const int PLAYM4_MAX_SUPPORTS = 500;
        //Wave coef range;
        public const int MIN_WAVE_COEF = -100;
        public const int MAX_WAVE_COEF = 100;

        //Timer type
        public const int TIMER_1 = 1; //Only 16 timers for every process.Default TIMER;
        public const int TIMER_2 = 2;//Not limit;But the precision less than TIMER_1; 

        //BUFFER TYPE
        public const int BUF_VIDEO_SRC = 1;
        public const int BUF_AUDIO_SRC = 2;
        public const int BUF_VIDEO_RENDER = 3;
        public const int BUF_AUDIO_RENDER = 4;

        //Error code
        public const int PLAYM4_NOERROR = 0;//no error
        public const int PLAYM4_PARA_OVER = 1;//input parameter is invalid;
        public const int PLAYM4_ORDER_ERROR = 2;//The order of the function to be called is error.
        public const int PLAYM4_TIMER_ERROR = 3;//Create multimedia clock failed;
        public const int PLAYM4_DEC_VIDEO_ERROR = 4;//Decode video data failed.
        public const int PLAYM4_DEC_AUDIO_ERROR = 5;//Decode audio data failed.
        public const int PLAYM4_ALLOC_MEMORY_ERROR = 6;//Allocate memory failed.
        public const int PLAYM4_OPEN_FILE_ERROR = 7;//Open the file failed.
        public const int PLAYM4_CREATE_OBJ_ERROR = 8;//Create thread or event failed
        public const int PLAYM4_CREATE_DDRAW_ERROR = 9;//Create DirectDraw object failed.
        public const int PLAYM4_CREATE_OFFSCREEN_ERROR = 10;//failed when creating off-screen surface.
        public const int PLAYM4_BUF_OVER = 11;//buffer is overflow
        public const int PLAYM4_CREATE_SOUND_ERROR = 12;//failed when creating audio device.	
        public const int PLAYM4_SET_VOLUME_ERROR = 13;//Set volume failed
        public const int PLAYM4_SUPPORT_FILE_ONLY = 14;//The function only support play file.
        public const int PLAYM4_SUPPORT_STREAM_ONLY = 15;//The function only support play stream.
        public const int PLAYM4_SYS_NOT_SUPPORT = 16;//System not support.
        public const int PLAYM4_FILEHEADER_UNKNOWN = 17;//No file header.
        public const int PLAYM4_VERSION_INCORRECT = 18;//The version of decoder and encoder is not adapted.  
        public const int PLAYM4_INIT_DECODER_ERROR = 19;//Initialize decoder failed.
        public const int PLAYM4_CHECK_FILE_ERROR = 20;//The file data is unknown.
        public const int PLAYM4_INIT_TIMER_ERROR = 21;//Initialize multimedia clock failed.
        public const int PLAYM4_BLT_ERROR = 22;//Blt failed.
        public const int PLAYM4_UPDATE_ERROR = 23;//Update failed.
        public const int PLAYM4_OPEN_FILE_ERROR_MULTI = 24;//openfile error, streamtype is multi
        public const int PLAYM4_OPEN_FILE_ERROR_VIDEO = 25;//openfile error, streamtype is video
        public const int PLAYM4_JPEG_COMPRESS_ERROR = 26;//JPEG compress error
        public const int PLAYM4_EXTRACT_NOT_SUPPORT = 27;//Don't support the version of this file.
        public const int PLAYM4_EXTRACT_DATA_ERROR = 28;//extract video data failed.
        public const int PLAYM4_SECRET_KEY_ERROR = 29;//Secret key is error //add 20071218

        //Max display regions.
        public const int MAX_DISPLAY_WND = 4;

        //Display type
        public const int DISPLAY_NORMAL = 1;
        public const int DISPLAY_QUARTER = 2;

        //Display buffers
        public const int MAX_DIS_FRAMES = 50;
        public const int MIN_DIS_FRAMES = 1;

        //Locate by
        public const int BY_FRAMENUM = 1;
        public const int BY_FRAMETIME = 2;

        //Source buffer
        public const int SOURCE_BUF_MAX = 1024 * 100000;
        public const int SOURCE_BUF_MIN = 1024 * 50;

        //Stream type
        public const int STREAME_REALTIME = 0;
        public const int STREAME_FILE = 1;

        //frame type
        public const int T_AUDIO16 = 101;
        public const int T_AUDIO8 = 100;
        public const int T_UYVY = 1;
        public const int T_YV12 = 3;
        public const int T_RGB32 = 7;

        //capability
        public const int SUPPORT_DDRAW = 1;
        public const int SUPPORT_BLT = 2;
        public const int SUPPORT_BLTFOURCC = 4;
        public const int SUPPORT_BLTSHRINKX = 8;
        public const int SUPPORT_BLTSHRINKY = 16;
        public const int SUPPORT_BLTSTRETCHX = 32;
        public const int SUPPORT_BLTSTRETCHY = 64;
        public const int SUPPORT_SSE = 128;
        public const int SUPPORT_MMX = 256;


        public const int FOURCC_HKMI = 0x484B4D49;

        public const int SYSTEM_NULL = 0;
        public const int SYSTEM_HIK = 1;
        public const int SYSTEM_MPEG2_PS = 2;
        public const int SYSTEM_MPEG2_TS = 3;
        public const int SYSTEM_RTP = 4;


        public const int VIDEO_NULL = 0;
        public const int VIDEO_H264 = 1;
        public const int VIDEO_MPEG4 = 3;


        public const int AUDIO_NULL = 0;
        public const int AUDIO_ADPCM = 4096;
        public const int AUDIO_MPEG = 8192;


        public const int AUDIO_G711_U = 28944;
        public const int AUDIO_G711_A = 28945;
        public const int AUDIO_G722_1 = 29217;
        public const int AUDIO_G723_1 = 29233;
        public const int AUDIO_G726 = 29280;
        public const int AUDIO_G729 = 29328;

        //Frame position
        public struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;

            public void Init()
            {
                wYear = 0;
                wMonth = 0;
                wDayOfWeek = 0;
                wDay = 0;
                wHour = 0;
                wMinute = 0;
                wSecond = 0;
                wMilliseconds = 0;
            }
        }

        public struct FRAME_POS
        {
            public int nFilePos;
            public int nFrameNum;
            public int nFrameTime;
            public int nErrorFrameNum;
            public IntPtr pErrorTime;
            public int nErrorLostFrameNum;
            public int nErrorFrameSize;

            public void Init()
            {
                nFilePos = 0;
                nFrameNum = 0;
                nFrameTime = 0;
                nErrorFrameNum = 0;
                pErrorTime = new IntPtr();
                nErrorLostFrameNum = 0;
                nErrorFrameSize = 0;
            }
        }

        //Frame Info
        public struct FRAME_INFO
        {
            public int nWidth;
            public int nHeight;
            public int nStamp;
            public int nType;
            public int nFrameRate;
            public uint dwFrameNum;

            public void Init()
            {
                nWidth = 0;
                nHeight = 0;
                nStamp = 0;
                nType = 0;
                nFrameRate = 0;
                dwFrameNum = 0;
            }
        }

        //Frame
        public struct FRAME_TYPE
        {
            [MarshalAsAttribute(UnmanagedType.LPStr)]
            public string pDataBuf;
            public int nSize;
            public int nFrameNum;
            public bool bIsAudio;
            public int nReserved;

            public void Init()
            {
                pDataBuf = "";
                nSize = 0;
                nFrameNum = 0;
                bIsAudio = false;
                nReserved = 0;
            }
        }

        //Watermark Info	//add by gb 080119
        public struct WATERMARK_INFO
        {
            [MarshalAsAttribute(UnmanagedType.LPStr)]
            public string pDataBuf;
            public int nSize;
            public int nFrameNum;
            public bool bRsaRight;
            public int nReserved;

            public void Init()
            {
                pDataBuf = "";
                nSize = 0;
                nFrameNum = 0;
                bRsaRight = false;
                nReserved = 0;
            }
        }

        // modified by gb 080425
        public struct HIK_MEDIAINFO
        {
            public uint media_fourcc;// "HKMI": 0x484B4D49 Hikvision Media Information
            public ushort media_version;
            public ushort device_id;

            public ushort system_format;
            public ushort video_format;

            public ushort audio_format;
            public byte audio_channels;
            public byte audio_bits_per_sample;
            public uint audio_samplesrate;
            public uint audio_bitrate;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] reserved;

            public void Init()
            {
                media_fourcc = 0;
                media_version = 0;
                device_id = 0;
                system_format = 0;
                video_format = 0;
                audio_format = 0;
                audio_channels = 0;
                audio_bits_per_sample = 0;
                audio_samplesrate = 0;
                audio_bitrate = 0;
                reserved = new uint[4];
            }
        }

        /*************************************************
        Function:	 ConverUiTimeToDateTime
        Description: 
        Input:		 void
        Output:      void
        Return:		 void
        *************************************************/
        public static DateTime ConverUiTimeToDateTime(uint uiTime)
        {
            int iYear = (int)((uiTime >> 26) + 2000);
            int iMonth = (int)((uiTime >> 22) & 15);
            int iDay = (int)((uiTime >> 17) & 31);
            int iHour = (int)((uiTime >> 12) & 31);
            int iMinute = (int)((uiTime >> 6) & 63);
            int iSecond = (int)((uiTime >> 0) & 63);
            DateTime dateTime = new DateTime(iYear, iMonth, iDay, iHour, iMinute, iSecond);
            return dateTime;
        }

        /*************************************************
        Function:	 GetTimeFromUiTime
        Description:  
        Input:		  void
        Output:       void
        Return:		  void
        *************************************************/
        public static void GetTimeFromUiTime(uint uiTime, ref uint uiHour, ref uint uiMinute, ref uint uiSecond)
        {
            uiHour = ((uiTime >> 12) & 31);
            uiMinute = ((uiTime >> 6) & 63);
            uiSecond = ((uiTime >> 0) & 63);
        }

        //API
        //Initialize DirecDraw.Now invalid.
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InitDDraw(IntPtr hWnd);
        //Release directDraw; Now invalid.
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RealeseDDraw();

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OpenFile(int nPort, String sFileName);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_CloseFile(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Play(int nPort, IntPtr hWnd);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Stop(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Pause(int nPort, uint nPause);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Fast(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Slow(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OneByOne(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetPlayPos(int nPort, float fRelativePos);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern float PlayM4_GetPlayPos(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetFileEndMsg(int nPort, IntPtr hWnd, uint nMsg);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetVolume(int nPort, ushort nVolume);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_StopSound();

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_PlaySound(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OpenStream(int nPort, ref byte pFileHeadBuf, uint nSize, uint nBufPoolSize);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InputData(int nPort, ref byte pBuf, uint nSize);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_CloseStream(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetCaps();

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetFileTime(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetFileTimeEx(int nPort, ref uint pStart, ref uint pStop, ref uint pRev);


        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetPlayedTime(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetPlayedFrames(int nPort);

        ////////////////ver 2.0 added///////////////////////////////////////
        public delegate void DECCBFUN(int nPort, IntPtr pBuf, int nSize, ref FRAME_INFO pFrameInfo, int nReserved1, int nReserved2);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecCallBack(int nPort, DECCBFUN DecCBFun);


        public delegate void DISPLAYCBFUN(int nPort, IntPtr pBuf, int nSize, int nWidth, int nHeight, int nStamp, int nType, int nReserved);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDisplayCallBack(int nPort, DISPLAYCBFUN DisplayCBFun);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PLayM4_ConvertToBmpFile(IntPtr pBuf, int nSize, int nWidth, int nHeight, int nType, string sFileName);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetFileTotalFrames(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetCurrentFrameRate(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetPlayedTimeEx(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetPlayedTimeEx(int nPort, uint nTime);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetCurrentFrameNum(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetStreamOpenMode(int nPort, uint nMode);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetFileHeadLength();

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetSdkVersion();

        ////////////////ver 2.2 added///////////////////////////////////////
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetLastError(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RefreshPlay(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetOverlayMode(int nPort, int bOverlay, uint colorKey);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetPictureSize(int nPort, ref int pWidth, ref int pHeight);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetPicQuality(int nPort, int bHighQuality);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_PlaySoundShare(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_StopSoundShare(int nPort);

        ////////////////ver 2.4 added///////////////////////////////////////
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetStreamOpenMode(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetOverlayMode(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetColorKey(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern ushort PlayM4_GetVolume(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetPictureQuality(int nPort, ref int bHighQuality);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetSourceBufferRemain(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ResetSourceBuffer(int nPort);

        public delegate void SOURCEBUFCALLBACKI(int nPort, uint nBufSize, uint dwUser, IntPtr pResvered);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetSourceBufCallBack(int nPort, uint nThreShold, SOURCEBUFCALLBACKI SourceBufCallBack, uint dwUser, IntPtr pReserved);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ResetSourceBufFlag(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDisplayBuf(int nPort, uint nNum);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetDisplayBuf(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OneByOneBack(int nPort);

        // PLAYM4_API BOOL __stdcall PlayM4_SetFileRefCallBack(LONG nPort, void (__stdcall *pFileRefDone)(DWORD nPort,DWORD nUser),DWORD nUser);
        public delegate void PFILEREFDONE(uint nPort, uint nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetFileRefCallBack(int nPort, PFILEREFDONE pFileRefDone, uint nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetKeyFramePos(int nPort, uint nValue, uint nType, ref FRAME_POS pFramePos);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetNextKeyFramePos(int nPort, uint nValue, uint nType, ref FRAME_POS pFramePos);


        //#if (WINVER >= 0x0400)
        //Note: These funtion must be builded under win2000 or above with Microsoft Platform sdk.
        //	    You can download the sdk from "http://www.microsoft.com/msdownload/platformsdk/sdkupdate/";
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InitDDrawDevice();

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern void PlayM4_ReleaseDDrawDevice();

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetDDrawDeviceTotalNums();

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDDrawDevice(int nPort, uint nDeviceNum);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetCapsEx(uint nDDrawDeviceNum);

        //#endif
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ThrowBFrameNum(int nPort, uint nNum);

        ////////////////ver 2.5 added///////////////////////////////////////
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDisplayType(int nPort, int nType);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetDisplayType(int nPort);

        ////////////////ver 3.0 added///////////////////////////////////////
        public struct tagRECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;

            public void Init()
            {
                left = 0;
                top = 0;
                right = 0;
                bottom = 0;
            }
        }

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecCBStream(int nPort, uint nStream);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDisplayRegion(int nPort, uint nRegionNum, ref tagRECT pSrcRect, System.IntPtr hDestWnd, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bEnable);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RefreshPlayEx(int nPort, uint nRegionNum);

        //#if (WINVER >= 0x0400)
        //Note: The funtion must be builded under win2000 or above with Microsoft Platform sdk.
        //	    You can download the sdk from http://www.microsoft.com/msdownload/platformsdk/sdkupdate/;
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDDrawDeviceEx(int nPort, uint nRegionNum, uint nDeviceNum);

        //#endif
        /////////////////v3.2 added/////////////////////////////////////////
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetRefValue(int nPort, ref byte pBuffer, ref uint pSize);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetRefValue(int nPort, ref byte pBuffer, uint nSize);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OpenStreamEx(int nPort, ref byte pFileHeadBuf, uint nSize, uint nBufPoolSize);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_CloseStreamEx(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InputVideoData(int nPort, ref byte pBuf, uint nSize);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InputAudioData(int nPort, ref byte pBuf, uint nSize);


        public delegate void DRAWFUN(int nPort, System.IntPtr hDc, int nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RigisterDrawFun(int nPort, DRAWFUN DrawFun, int nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RegisterDrawFun(int nPort, DRAWFUN DrawFun, int nUser);

        //////////////////v3.4/////////////////////////////////////////////////////
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetTimerType(int nPort, uint nTimerType, uint nReserved);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetTimerType(int nPort, ref uint pTimerType, ref uint pReserved);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ResetBuffer(int nPort, uint nBufType);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetBufferValue(int nPort, uint nBufType);

        //////////////////V3.6/////////////////////////////////////////////////////////
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_AdjustWaveAudio(int nPort, int nCoefficient);

        public delegate void FUNVERYFY(int nPort, ref FRAME_POS pFilePos, uint bIsVideo, uint nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetVerifyCallBack(int nPort, uint nBeginTime, uint nEndTime, FUNVERYFY funVerify, uint nUser);

        public delegate void FUNAUDIO(int nPort, string pAudioBuf, int nSize, int nStamp, int nType, int nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetAudioCallBack(int nPort, FUNAUDIO funAudio, int nUser);


        public delegate void FUNENCCHANGE(int nPort, int nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetEncTypeChangeCallBack(int nPort, FUNENCCHANGE funEncChange, int nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetColor(int nPort, uint nRegionNum, int nBrightness, int nContrast, int nSaturation, int nHue);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetColor(int nPort, uint nRegionNum, ref int pBrightness, ref int pContrast, ref int pSaturation, ref int pHue);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetEncChangeMsg(int nPort, System.IntPtr hWnd, uint nMsg);

        public delegate void FUNGETORIGNALFRAME(int nPort, ref FRAME_TYPE frameType, int nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetOriginalFrameCallBack(int nPort, int bIsChange, int bNormalSpeed, int nStartFrameNum, int nStartStamp, int nFileHeader, FUNGETORIGNALFRAME funGetOrignalFrame, int nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetFileSpecialAttr(int nPort, ref uint pTimeStamp, ref uint pFileNum, ref uint pReserved);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetSpecialData(int nPort);

        public delegate void FUNCHECKWATERMARK(int nPort, ref WATERMARK_INFO pWatermarkInfo, uint nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetCheckWatermarkCallBack(int nPort, FUNCHECKWATERMARK funCheckWatermark, uint nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetImageSharpen(int nPort, uint nLevel);

        public delegate void FUNTHROWBFRAME(int nPort, uint nBFrame, uint nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetThrowBFrameCallBack(int nPort, FUNTHROWBFRAME funThrowBFrame, uint nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecodeFrameType(int nPort, uint nFrameType);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetPlayMode(int nPort, int bNormal);

        public delegate void FUNGETUSERDATA(int nPort, ref byte pUserBuf, uint nBufLen, uint nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetGetUserDataCallBack(int nPort, FUNGETUSERDATA funGetUserData, uint nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetOverlayFlipMode(int nPort, int bTrue);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetAbsFrameNum(int nPort);

        //////////////////V4.7.0.0//////////////////////////////////////////////////////
        ////convert yuv to jpeg
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ConvertToJpegFile(IntPtr pBuf, int nSize, int nWidth, int nHeight, int nType, string sFileName);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetJpegQuality(int nQuality);

        //set deflash
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDeflash(int nPort, int bDefalsh);

        //////////////////V4.8.0.0/////////////////////////////////////////////////////////
        //check discontinuous frame number as error data?
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_CheckDiscontinuousFrameNum(int nPort, int bCheck);

        //get bmp or jpeg
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetBMP(int nPort, ref byte pBitmap, uint nBufSize, ref uint pBmpSize);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetJPEG(int nPort, IntPtr pJpeg, uint nBufSize, ref uint pJpegSize);

        //dec call back mend
        //public delegate void DECCBFUN(int nPort, string pBuf, int nSize, ref FRAME_INFO pFrameInfo, int nUser, int nReserved2);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecCallBackMend(int nPort, DECCBFUN DecCBFun, int nUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetSecretKey(int nPort, int lKeyType, string pSecretKey, int lKeyLen);

        // add by gb 2007-12-23
        public delegate void FILEENDCALLBACK(int nPort, System.IntPtr pUser);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetFileEndCallback(int nPort, FILEENDCALLBACK FileEndCallback, IntPtr pUser);

        // add by gb 080131 version 4.9.0.1
        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetPort(ref int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_FreePort(int nPort);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SyncToAudio(int nPort, int bSyncToAudio);

        //public delegate void Anonymous_b532dad6_7470_4b10_9638_c82a363cd853(int nPort, System.IntPtr pBuf, int nSize, ref FRAME_INFO pFrameInfo, int nReserved1, int nReserved2);

        [DllImport("X86dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecCallBackEx(int nPort, DECCBFUN DecCBFun, IntPtr pDest, int nDestSize);
    }

    class PlayCtrl_X64
    {
        public PlayCtrl_X64()
        {
            //
            // TODO: 
            //
        }

        public const string PLAYM4_API = "extern \"C\"__declspec(dllexport)";

        // public const string PLAYM4_API = "extern \"C\" __declspec(dllimport)";


        //Max channel numbers
        public const int PLAYM4_MAX_SUPPORTS = 500;
        //Wave coef range;
        public const int MIN_WAVE_COEF = -100;
        public const int MAX_WAVE_COEF = 100;

        //Timer type
        public const int TIMER_1 = 1; //Only 16 timers for every process.Default TIMER;
        public const int TIMER_2 = 2;//Not limit;But the precision less than TIMER_1; 

        //BUFFER TYPE
        public const int BUF_VIDEO_SRC = 1;
        public const int BUF_AUDIO_SRC = 2;
        public const int BUF_VIDEO_RENDER = 3;
        public const int BUF_AUDIO_RENDER = 4;

        //Error code
        public const int PLAYM4_NOERROR = 0;//no error
        public const int PLAYM4_PARA_OVER = 1;//input parameter is invalid;
        public const int PLAYM4_ORDER_ERROR = 2;//The order of the function to be called is error.
        public const int PLAYM4_TIMER_ERROR = 3;//Create multimedia clock failed;
        public const int PLAYM4_DEC_VIDEO_ERROR = 4;//Decode video data failed.
        public const int PLAYM4_DEC_AUDIO_ERROR = 5;//Decode audio data failed.
        public const int PLAYM4_ALLOC_MEMORY_ERROR = 6;//Allocate memory failed.
        public const int PLAYM4_OPEN_FILE_ERROR = 7;//Open the file failed.
        public const int PLAYM4_CREATE_OBJ_ERROR = 8;//Create thread or event failed
        public const int PLAYM4_CREATE_DDRAW_ERROR = 9;//Create DirectDraw object failed.
        public const int PLAYM4_CREATE_OFFSCREEN_ERROR = 10;//failed when creating off-screen surface.
        public const int PLAYM4_BUF_OVER = 11;//buffer is overflow
        public const int PLAYM4_CREATE_SOUND_ERROR = 12;//failed when creating audio device.	
        public const int PLAYM4_SET_VOLUME_ERROR = 13;//Set volume failed
        public const int PLAYM4_SUPPORT_FILE_ONLY = 14;//The function only support play file.
        public const int PLAYM4_SUPPORT_STREAM_ONLY = 15;//The function only support play stream.
        public const int PLAYM4_SYS_NOT_SUPPORT = 16;//System not support.
        public const int PLAYM4_FILEHEADER_UNKNOWN = 17;//No file header.
        public const int PLAYM4_VERSION_INCORRECT = 18;//The version of decoder and encoder is not adapted.  
        public const int PLAYM4_INIT_DECODER_ERROR = 19;//Initialize decoder failed.
        public const int PLAYM4_CHECK_FILE_ERROR = 20;//The file data is unknown.
        public const int PLAYM4_INIT_TIMER_ERROR = 21;//Initialize multimedia clock failed.
        public const int PLAYM4_BLT_ERROR = 22;//Blt failed.
        public const int PLAYM4_UPDATE_ERROR = 23;//Update failed.
        public const int PLAYM4_OPEN_FILE_ERROR_MULTI = 24;//openfile error, streamtype is multi
        public const int PLAYM4_OPEN_FILE_ERROR_VIDEO = 25;//openfile error, streamtype is video
        public const int PLAYM4_JPEG_COMPRESS_ERROR = 26;//JPEG compress error
        public const int PLAYM4_EXTRACT_NOT_SUPPORT = 27;//Don't support the version of this file.
        public const int PLAYM4_EXTRACT_DATA_ERROR = 28;//extract video data failed.
        public const int PLAYM4_SECRET_KEY_ERROR = 29;//Secret key is error //add 20071218

        //Max display regions.
        public const int MAX_DISPLAY_WND = 4;

        //Display type
        public const int DISPLAY_NORMAL = 1;
        public const int DISPLAY_QUARTER = 2;

        //Display buffers
        public const int MAX_DIS_FRAMES = 50;
        public const int MIN_DIS_FRAMES = 1;

        //Locate by
        public const int BY_FRAMENUM = 1;
        public const int BY_FRAMETIME = 2;

        //Source buffer
        public const int SOURCE_BUF_MAX = 1024 * 100000;
        public const int SOURCE_BUF_MIN = 1024 * 50;

        //Stream type
        public const int STREAME_REALTIME = 0;
        public const int STREAME_FILE = 1;

        //frame type
        public const int T_AUDIO16 = 101;
        public const int T_AUDIO8 = 100;
        public const int T_UYVY = 1;
        public const int T_YV12 = 3;
        public const int T_RGB32 = 7;

        //capability
        public const int SUPPORT_DDRAW = 1;
        public const int SUPPORT_BLT = 2;
        public const int SUPPORT_BLTFOURCC = 4;
        public const int SUPPORT_BLTSHRINKX = 8;
        public const int SUPPORT_BLTSHRINKY = 16;
        public const int SUPPORT_BLTSTRETCHX = 32;
        public const int SUPPORT_BLTSTRETCHY = 64;
        public const int SUPPORT_SSE = 128;
        public const int SUPPORT_MMX = 256;


        public const int FOURCC_HKMI = 0x484B4D49;

        public const int SYSTEM_NULL = 0;
        public const int SYSTEM_HIK = 1;
        public const int SYSTEM_MPEG2_PS = 2;
        public const int SYSTEM_MPEG2_TS = 3;
        public const int SYSTEM_RTP = 4;


        public const int VIDEO_NULL = 0;
        public const int VIDEO_H264 = 1;
        public const int VIDEO_MPEG4 = 3;


        public const int AUDIO_NULL = 0;
        public const int AUDIO_ADPCM = 4096;
        public const int AUDIO_MPEG = 8192;


        public const int AUDIO_G711_U = 28944;
        public const int AUDIO_G711_A = 28945;
        public const int AUDIO_G722_1 = 29217;
        public const int AUDIO_G723_1 = 29233;
        public const int AUDIO_G726 = 29280;
        public const int AUDIO_G729 = 29328;

        //Frame position
        public struct SYSTEMTIME
        {
            public ushort wYear;
            public ushort wMonth;
            public ushort wDayOfWeek;
            public ushort wDay;
            public ushort wHour;
            public ushort wMinute;
            public ushort wSecond;
            public ushort wMilliseconds;

            public void Init()
            {
                wYear = 0;
                wMonth = 0;
                wDayOfWeek = 0;
                wDay = 0;
                wHour = 0;
                wMinute = 0;
                wSecond = 0;
                wMilliseconds = 0;
            }
        }

        public struct FRAME_POS
        {
            public int nFilePos;
            public int nFrameNum;
            public int nFrameTime;
            public int nErrorFrameNum;
            public IntPtr pErrorTime;
            public int nErrorLostFrameNum;
            public int nErrorFrameSize;

            public void Init()
            {
                nFilePos = 0;
                nFrameNum = 0;
                nFrameTime = 0;
                nErrorFrameNum = 0;
                pErrorTime = new IntPtr();
                nErrorLostFrameNum = 0;
                nErrorFrameSize = 0;
            }
        }

        //Frame Info
        public struct FRAME_INFO
        {
            public int nWidth;
            public int nHeight;
            public int nStamp;
            public int nType;
            public int nFrameRate;
            public uint dwFrameNum;

            public void Init()
            {
                nWidth = 0;
                nHeight = 0;
                nStamp = 0;
                nType = 0;
                nFrameRate = 0;
                dwFrameNum = 0;
            }
        }

        //Frame
        public struct FRAME_TYPE
        {
            [MarshalAsAttribute(UnmanagedType.LPStr)]
            public string pDataBuf;
            public int nSize;
            public int nFrameNum;
            public bool bIsAudio;
            public int nReserved;

            public void Init()
            {
                pDataBuf = "";
                nSize = 0;
                nFrameNum = 0;
                bIsAudio = false;
                nReserved = 0;
            }
        }

        //Watermark Info	//add by gb 080119
        public struct WATERMARK_INFO
        {
            [MarshalAsAttribute(UnmanagedType.LPStr)]
            public string pDataBuf;
            public int nSize;
            public int nFrameNum;
            public bool bRsaRight;
            public int nReserved;

            public void Init()
            {
                pDataBuf = "";
                nSize = 0;
                nFrameNum = 0;
                bRsaRight = false;
                nReserved = 0;
            }
        }

        // modified by gb 080425
        public struct HIK_MEDIAINFO
        {
            public uint media_fourcc;// "HKMI": 0x484B4D49 Hikvision Media Information
            public ushort media_version;
            public ushort device_id;

            public ushort system_format;
            public ushort video_format;

            public ushort audio_format;
            public byte audio_channels;
            public byte audio_bits_per_sample;
            public uint audio_samplesrate;
            public uint audio_bitrate;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] reserved;

            public void Init()
            {
                media_fourcc = 0;
                media_version = 0;
                device_id = 0;
                system_format = 0;
                video_format = 0;
                audio_format = 0;
                audio_channels = 0;
                audio_bits_per_sample = 0;
                audio_samplesrate = 0;
                audio_bitrate = 0;
                reserved = new uint[4];
            }
        }

        /*************************************************
        Function:	 ConverUiTimeToDateTime
        Description: 
        Input:		 void
        Output:      void
        Return:		 void
        *************************************************/
        public static DateTime ConverUiTimeToDateTime(uint uiTime)
        {
            int iYear = (int)((uiTime >> 26) + 2000);
            int iMonth = (int)((uiTime >> 22) & 15);
            int iDay = (int)((uiTime >> 17) & 31);
            int iHour = (int)((uiTime >> 12) & 31);
            int iMinute = (int)((uiTime >> 6) & 63);
            int iSecond = (int)((uiTime >> 0) & 63);
            DateTime dateTime = new DateTime(iYear, iMonth, iDay, iHour, iMinute, iSecond);
            return dateTime;
        }

        /*************************************************
        Function:	 GetTimeFromUiTime
        Description:  
        Input:		  void
        Output:       void
        Return:		  void
        *************************************************/
        public static void GetTimeFromUiTime(uint uiTime, ref uint uiHour, ref uint uiMinute, ref uint uiSecond)
        {
            uiHour = ((uiTime >> 12) & 31);
            uiMinute = ((uiTime >> 6) & 63);
            uiSecond = ((uiTime >> 0) & 63);
        }

        //API
        //Initialize DirecDraw.Now invalid.
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InitDDraw(IntPtr hWnd);
        //Release directDraw; Now invalid.
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RealeseDDraw();

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OpenFile(int nPort, String sFileName);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_CloseFile(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Play(int nPort, IntPtr hWnd);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Stop(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Pause(int nPort, uint nPause);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Fast(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_Slow(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OneByOne(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetPlayPos(int nPort, float fRelativePos);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern float PlayM4_GetPlayPos(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetFileEndMsg(int nPort, IntPtr hWnd, uint nMsg);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetVolume(int nPort, ushort nVolume);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_StopSound();

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_PlaySound(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OpenStream(int nPort, ref byte pFileHeadBuf, uint nSize, uint nBufPoolSize);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InputData(int nPort, ref byte pBuf, uint nSize);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_CloseStream(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetCaps();

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetFileTime(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetFileTimeEx(int nPort, ref uint pStart, ref uint pStop, ref uint pRev);


        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetPlayedTime(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetPlayedFrames(int nPort);

        ////////////////ver 2.0 added///////////////////////////////////////
        public delegate void DECCBFUN(int nPort, IntPtr pBuf, int nSize, ref FRAME_INFO pFrameInfo, int nReserved1, int nReserved2);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecCallBack(int nPort, DECCBFUN DecCBFun);


        public delegate void DISPLAYCBFUN(int nPort, IntPtr pBuf, int nSize, int nWidth, int nHeight, int nStamp, int nType, int nReserved);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDisplayCallBack(int nPort, DISPLAYCBFUN DisplayCBFun);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PLayM4_ConvertToBmpFile(IntPtr pBuf, int nSize, int nWidth, int nHeight, int nType, string sFileName);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetFileTotalFrames(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetCurrentFrameRate(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetPlayedTimeEx(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetPlayedTimeEx(int nPort, uint nTime);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetCurrentFrameNum(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetStreamOpenMode(int nPort, uint nMode);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetFileHeadLength();

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetSdkVersion();

        ////////////////ver 2.2 added///////////////////////////////////////
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetLastError(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RefreshPlay(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetOverlayMode(int nPort, int bOverlay, uint colorKey);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetPictureSize(int nPort, ref int pWidth, ref int pHeight);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetPicQuality(int nPort, int bHighQuality);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_PlaySoundShare(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_StopSoundShare(int nPort);

        ////////////////ver 2.4 added///////////////////////////////////////
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetStreamOpenMode(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetOverlayMode(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetColorKey(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern ushort PlayM4_GetVolume(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetPictureQuality(int nPort, ref int bHighQuality);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetSourceBufferRemain(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ResetSourceBuffer(int nPort);

        public delegate void SOURCEBUFCALLBACKI(int nPort, uint nBufSize, uint dwUser, IntPtr pResvered);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetSourceBufCallBack(int nPort, uint nThreShold, SOURCEBUFCALLBACKI SourceBufCallBack, uint dwUser, IntPtr pReserved);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ResetSourceBufFlag(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDisplayBuf(int nPort, uint nNum);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetDisplayBuf(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OneByOneBack(int nPort);

        // PLAYM4_API BOOL __stdcall PlayM4_SetFileRefCallBack(LONG nPort, void (__stdcall *pFileRefDone)(DWORD nPort,DWORD nUser),DWORD nUser);
        public delegate void PFILEREFDONE(uint nPort, uint nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetFileRefCallBack(int nPort, PFILEREFDONE pFileRefDone, uint nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetKeyFramePos(int nPort, uint nValue, uint nType, ref FRAME_POS pFramePos);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetNextKeyFramePos(int nPort, uint nValue, uint nType, ref FRAME_POS pFramePos);


        //#if (WINVER >= 0x0400)
        //Note: These funtion must be builded under win2000 or above with Microsoft Platform sdk.
        //	    You can download the sdk from "http://www.microsoft.com/msdownload/platformsdk/sdkupdate/";
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InitDDrawDevice();

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern void PlayM4_ReleaseDDrawDevice();

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetDDrawDeviceTotalNums();

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDDrawDevice(int nPort, uint nDeviceNum);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetCapsEx(uint nDDrawDeviceNum);

        //#endif
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ThrowBFrameNum(int nPort, uint nNum);

        ////////////////ver 2.5 added///////////////////////////////////////
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDisplayType(int nPort, int nType);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern int PlayM4_GetDisplayType(int nPort);

        ////////////////ver 3.0 added///////////////////////////////////////
        public struct tagRECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;

            public void Init()
            {
                left = 0;
                top = 0;
                right = 0;
                bottom = 0;
            }
        }

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecCBStream(int nPort, uint nStream);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDisplayRegion(int nPort, uint nRegionNum, ref tagRECT pSrcRect, System.IntPtr hDestWnd, [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.Bool)] bool bEnable);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RefreshPlayEx(int nPort, uint nRegionNum);

        //#if (WINVER >= 0x0400)
        //Note: The funtion must be builded under win2000 or above with Microsoft Platform sdk.
        //	    You can download the sdk from http://www.microsoft.com/msdownload/platformsdk/sdkupdate/;
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDDrawDeviceEx(int nPort, uint nRegionNum, uint nDeviceNum);

        //#endif
        /////////////////v3.2 added/////////////////////////////////////////
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetRefValue(int nPort, ref byte pBuffer, ref uint pSize);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetRefValue(int nPort, ref byte pBuffer, uint nSize);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_OpenStreamEx(int nPort, ref byte pFileHeadBuf, uint nSize, uint nBufPoolSize);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_CloseStreamEx(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InputVideoData(int nPort, ref byte pBuf, uint nSize);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_InputAudioData(int nPort, ref byte pBuf, uint nSize);


        public delegate void DRAWFUN(int nPort, System.IntPtr hDc, int nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RigisterDrawFun(int nPort, DRAWFUN DrawFun, int nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_RegisterDrawFun(int nPort, DRAWFUN DrawFun, int nUser);

        //////////////////v3.4/////////////////////////////////////////////////////
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetTimerType(int nPort, uint nTimerType, uint nReserved);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetTimerType(int nPort, ref uint pTimerType, ref uint pReserved);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ResetBuffer(int nPort, uint nBufType);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetBufferValue(int nPort, uint nBufType);

        //////////////////V3.6/////////////////////////////////////////////////////////
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_AdjustWaveAudio(int nPort, int nCoefficient);

        public delegate void FUNVERYFY(int nPort, ref FRAME_POS pFilePos, uint bIsVideo, uint nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetVerifyCallBack(int nPort, uint nBeginTime, uint nEndTime, FUNVERYFY funVerify, uint nUser);

        public delegate void FUNAUDIO(int nPort, string pAudioBuf, int nSize, int nStamp, int nType, int nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetAudioCallBack(int nPort, FUNAUDIO funAudio, int nUser);


        public delegate void FUNENCCHANGE(int nPort, int nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetEncTypeChangeCallBack(int nPort, FUNENCCHANGE funEncChange, int nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetColor(int nPort, uint nRegionNum, int nBrightness, int nContrast, int nSaturation, int nHue);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetColor(int nPort, uint nRegionNum, ref int pBrightness, ref int pContrast, ref int pSaturation, ref int pHue);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetEncChangeMsg(int nPort, System.IntPtr hWnd, uint nMsg);

        public delegate void FUNGETORIGNALFRAME(int nPort, ref FRAME_TYPE frameType, int nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetOriginalFrameCallBack(int nPort, int bIsChange, int bNormalSpeed, int nStartFrameNum, int nStartStamp, int nFileHeader, FUNGETORIGNALFRAME funGetOrignalFrame, int nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetFileSpecialAttr(int nPort, ref uint pTimeStamp, ref uint pFileNum, ref uint pReserved);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetSpecialData(int nPort);

        public delegate void FUNCHECKWATERMARK(int nPort, ref WATERMARK_INFO pWatermarkInfo, uint nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetCheckWatermarkCallBack(int nPort, FUNCHECKWATERMARK funCheckWatermark, uint nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetImageSharpen(int nPort, uint nLevel);

        public delegate void FUNTHROWBFRAME(int nPort, uint nBFrame, uint nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetThrowBFrameCallBack(int nPort, FUNTHROWBFRAME funThrowBFrame, uint nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecodeFrameType(int nPort, uint nFrameType);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetPlayMode(int nPort, int bNormal);

        public delegate void FUNGETUSERDATA(int nPort, ref byte pUserBuf, uint nBufLen, uint nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetGetUserDataCallBack(int nPort, FUNGETUSERDATA funGetUserData, uint nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetOverlayFlipMode(int nPort, int bTrue);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern uint PlayM4_GetAbsFrameNum(int nPort);

        //////////////////V4.7.0.0//////////////////////////////////////////////////////
        ////convert yuv to jpeg
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_ConvertToJpegFile(IntPtr pBuf, int nSize, int nWidth, int nHeight, int nType, string sFileName);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetJpegQuality(int nQuality);

        //set deflash
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDeflash(int nPort, int bDefalsh);

        //////////////////V4.8.0.0/////////////////////////////////////////////////////////
        //check discontinuous frame number as error data?
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_CheckDiscontinuousFrameNum(int nPort, int bCheck);

        //get bmp or jpeg
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetBMP(int nPort, ref byte pBitmap, uint nBufSize, ref uint pBmpSize);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetJPEG(int nPort, IntPtr pJpeg, uint nBufSize, ref uint pJpegSize);

        //dec call back mend
        //public delegate void DECCBFUN(int nPort, string pBuf, int nSize, ref FRAME_INFO pFrameInfo, int nUser, int nReserved2);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecCallBackMend(int nPort, DECCBFUN DecCBFun, int nUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetSecretKey(int nPort, int lKeyType, string pSecretKey, int lKeyLen);

        // add by gb 2007-12-23
        public delegate void FILEENDCALLBACK(int nPort, System.IntPtr pUser);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetFileEndCallback(int nPort, FILEENDCALLBACK FileEndCallback, IntPtr pUser);

        // add by gb 080131 version 4.9.0.1
        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_GetPort(ref int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_FreePort(int nPort);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SyncToAudio(int nPort, int bSyncToAudio);

        //public delegate void Anonymous_b532dad6_7470_4b10_9638_c82a363cd853(int nPort, System.IntPtr pBuf, int nSize, ref FRAME_INFO pFrameInfo, int nReserved1, int nReserved2);

        [DllImport("X64dll/PlayCtrl.dll")]
        public static extern bool PlayM4_SetDecCallBackEx(int nPort, DECCBFUN DecCBFun, IntPtr pDest, int nDestSize);
    }
}

