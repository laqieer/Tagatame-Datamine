// Decompiled with JetBrains decompiler
// Type: LogMonitor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using Slack;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000113")]
[AddComponentMenu("")]
public class LogMonitor : MonoBehaviour
{
  [Token(Token = "0x40004FF")]
  [FieldOffset(Offset = "0x0")]
  public static LogMonitor mInstnace;
  [Token(Token = "0x4000500")]
  [FieldOffset(Offset = "0xC")]
  private List<LogMonitor.Log> mLogs;
  [Token(Token = "0x4000501")]
  [FieldOffset(Offset = "0x10")]
  private int mLogCount;
  [Token(Token = "0x4000502")]
  [FieldOffset(Offset = "0x14")]
  private GUIStyle mBackgroundStyle;
  [Token(Token = "0x4000503")]
  [FieldOffset(Offset = "0x18")]
  private GUIStyle mErrorStyle;
  [Token(Token = "0x4000504")]
  [FieldOffset(Offset = "0x1C")]
  private GUIStyle mExceptionStyle;
  [Token(Token = "0x4000505")]
  [FieldOffset(Offset = "0x20")]
  private GUIStyle mStackTraceStyle;
  [Token(Token = "0x4000506")]
  [FieldOffset(Offset = "0x24")]
  private string mStackTrace;
  [Token(Token = "0x4000507")]
  [FieldOffset(Offset = "0x28")]
  private SlackOption option;
  [Token(Token = "0x4000508")]
  [FieldOffset(Offset = "0x2C")]
  private Texture2D mErrorStyle_BackgroundNormal;
  [Token(Token = "0x4000509")]
  [FieldOffset(Offset = "0x30")]
  private Texture2D mErrorStyle_BackgroundHover;
  [Token(Token = "0x400050A")]
  [FieldOffset(Offset = "0x34")]
  private Texture2D mStackTraceStyle_BackgroundNormal;
  [Token(Token = "0x400050B")]
  [FieldOffset(Offset = "0x38")]
  private Texture2D mExceptionStyle_BackgroundNormal;
  [Token(Token = "0x400050C")]
  [FieldOffset(Offset = "0x3C")]
  private Texture2D mExceptionStyle_BackgroundHover;
  [Token(Token = "0x400050D")]
  [FieldOffset(Offset = "0x40")]
  private Texture2D mBackgroundStyle_BackgroundNormal;
  [Token(Token = "0x400050E")]
  [FieldOffset(Offset = "0x44")]
  private LogMonitor.GUICallback mCallback;
  [Token(Token = "0x400050F")]
  [FieldOffset(Offset = "0x48")]
  private bool mDisp;
  [Token(Token = "0x4000510")]
  [FieldOffset(Offset = "0x49")]
  private bool mSending;

  [Token(Token = "0x60006FC")]
  [Address(RVA = "0xD5F960", Offset = "0xD5E760", VA = "0x10D5F960")]
  public static void Start()
  {
  }

  [Token(Token = "0x17000115")]
  public static LogMonitor Instance
  {
    [Token(Token = "0x60006FD"), Address(RVA = "0xD5FB10", Offset = "0xD5E910", VA = "0x10D5FB10")] get
    {
      return (LogMonitor) null;
    }
  }

  [Token(Token = "0x17000116")]
  public bool isDisp
  {
    [Token(Token = "0x60006FE"), Address(RVA = "0x661B10", Offset = "0x660910", VA = "0x10661B10")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x17000117")]
  public bool IsSend
  {
    [Token(Token = "0x60006FF"), Address(RVA = "0x2B5EE0", Offset = "0x2B4CE0", VA = "0x102B5EE0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000700")]
  [Address(RVA = "0xD5D430", Offset = "0xD5C230", VA = "0x10D5D430")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000701")]
  [Address(RVA = "0xD5F950", Offset = "0xD5E750", VA = "0x10D5F950")]
  public void SetDisp(bool value)
  {
  }

  [Token(Token = "0x6000702")]
  [Address(RVA = "0xD5D970", Offset = "0xD5C770", VA = "0x10D5D970")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000703")]
  [Address(RVA = "0xD5D8E0", Offset = "0xD5C6E0", VA = "0x10D5D8E0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000704")]
  [Address(RVA = "0xD5DA00", Offset = "0xD5C800", VA = "0x10D5DA00")]
  private void OnGUICallback()
  {
  }

  [Token(Token = "0x6000705")]
  [Address(RVA = "0xD5D580", Offset = "0xD5C380", VA = "0x10D5D580")]
  private void HandleLog(string logString, string stackTrace, LogType type)
  {
  }

  [Token(Token = "0x6000706")]
  [Address(RVA = "0xD5D4A0", Offset = "0xD5C2A0", VA = "0x10D5D4A0")]
  public void Clear()
  {
  }

  [Token(Token = "0x6000707")]
  [Address(RVA = "0xD5F640", Offset = "0xD5E440", VA = "0x10D5F640")]
  public bool SendSlack(
    LogMonitor.SendType send_type,
    string send_message,
    Action start_callback,
    Action end_callback,
    string screenRecordingFilename = null,
    SlackOption option = null)
  {
    return new bool();
  }

  [Token(Token = "0x6000708")]
  [Address(RVA = "0xD5F4C0", Offset = "0xD5E2C0", VA = "0x10D5F4C0")]
  private IEnumerator PostSlack(
    LogMonitor.SendType send_type,
    string sendFileName,
    string sendMessage,
    Action start_callback,
    Action end_callback,
    SlackOption option = null)
  {
    return (IEnumerator) null;
  }

  [Token(Token = "0x6000709")]
  [Address(RVA = "0xD5F510", Offset = "0xD5E310", VA = "0x10D5F510")]
  private void SaveScreeShot(string filename)
  {
  }

  [Token(Token = "0x600070A")]
  [Address(RVA = "0xD5D560", Offset = "0xD5C360", VA = "0x10D5D560")]
  public void DirectLog(string logString)
  {
  }

  [Token(Token = "0x600070B")]
  [Address(RVA = "0xD5FA60", Offset = "0xD5E860", VA = "0x10D5FA60")]
  public LogMonitor()
  {
  }

  [Token(Token = "0x2000114")]
  public enum SendType
  {
    [Token(Token = "0x4000512")] MESSAGE,
    [Token(Token = "0x4000513")] SCREENSHOT,
    [Token(Token = "0x4000514")] MOVIE,
    [Token(Token = "0x4000515")] TWITTER_SS,
    [Token(Token = "0x4000516")] MESSAGE_FILE,
  }

  [Token(Token = "0x2000115")]
  private class Log
  {
    [Token(Token = "0x4000517")]
    [FieldOffset(Offset = "0x8")]
    public int index;
    [Token(Token = "0x4000518")]
    [FieldOffset(Offset = "0xC")]
    public string logString;
    [Token(Token = "0x4000519")]
    [FieldOffset(Offset = "0x10")]
    public string stackTrace;
    [Token(Token = "0x400051A")]
    [FieldOffset(Offset = "0x14")]
    public LogType type;

    [Token(Token = "0x600070C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Log()
    {
    }
  }

  [Token(Token = "0x2000116")]
  [Serializable]
  public class ErrorInfo
  {
    [Token(Token = "0x400051B")]
    [FieldOffset(Offset = "0x8")]
    public string productname;
    [Token(Token = "0x400051C")]
    [FieldOffset(Offset = "0xC")]
    public string assets;
    [Token(Token = "0x400051D")]
    [FieldOffset(Offset = "0x10")]
    public string assets_ex;
    [Token(Token = "0x400051E")]
    [FieldOffset(Offset = "0x14")]
    public string appver;
    [Token(Token = "0x400051F")]
    [FieldOffset(Offset = "0x18")]
    public string dlcver;
    [Token(Token = "0x4000520")]
    [FieldOffset(Offset = "0x1C")]
    public string netver;
    [Token(Token = "0x4000521")]
    [FieldOffset(Offset = "0x20")]
    public string host;
    [Token(Token = "0x4000522")]
    [FieldOffset(Offset = "0x24")]
    public string code;
    [Token(Token = "0x4000523")]
    [FieldOffset(Offset = "0x28")]
    public string uid;
    [Token(Token = "0x4000524")]
    [FieldOffset(Offset = "0x2C")]
    public string name;
    [Token(Token = "0x4000525")]
    [FieldOffset(Offset = "0x30")]
    public string use_info;

    [Token(Token = "0x600070D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ErrorInfo()
    {
    }
  }

  [Token(Token = "0x2000117")]
  [Serializable]
  public class NotificationMessage
  {
    [Token(Token = "0x4000526")]
    [FieldOffset(Offset = "0x8")]
    public string message;

    [Token(Token = "0x600070E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public NotificationMessage()
    {
    }
  }

  [Token(Token = "0x2000118")]
  [AddComponentMenu("")]
  public class GUICallback : MonoBehaviour
  {
    [Token(Token = "0x4000527")]
    [FieldOffset(Offset = "0xC")]
    public LogMonitor.GUICallback.GUIEvent OnGUIListener;

    [Token(Token = "0x600070F")]
    [Address(RVA = "0x891720", Offset = "0x890520", VA = "0x10891720")]
    private void OnGUI()
    {
    }

    [Token(Token = "0x6000710")]
    [Address(RVA = "0xD551D0", Offset = "0xD53FD0", VA = "0x10D551D0")]
    public GUICallback()
    {
    }

    [Token(Token = "0x2000119")]
    public delegate void GUIEvent();
  }
}
