// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_SendLogMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using LogKit;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200160B")]
  [FlowNode.NodeType("SendLogKit/SendMessage", 32741)]
  [FlowNode.Pin(0, "RequestActionLog", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "RequestNativeBaseLog", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(10, "OutPut", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("")]
  public class FlowNode_SendLogMessage : FlowNode
  {
    [Token(Token = "0x4004FEB")]
    private const int REQUEST_ACTION_LOG = 0;
    [Token(Token = "0x4004FEC")]
    private const int REQUEST_NATIVEBASE_LOG = 1;
    [Token(Token = "0x4004FED")]
    private const string BaseLoggerTitle = "application";
    [Token(Token = "0x4004FEE")]
    private const LogLevel BaseLogLevel = LogLevel.Info;
    [Token(Token = "0x4004FEF")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private string mLoggerTitle;
    [Token(Token = "0x4004FF0")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private string mTag;
    [Token(Token = "0x4004FF1")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private LogLevel mLogLevel;
    [Token(Token = "0x4004FF2")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private string mMessage;
    [Token(Token = "0x4004FF3")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool bDevieceID;
    [Token(Token = "0x4004FF4")]
    [FieldOffset(Offset = "0x29")]
    [SerializeField]
    private bool bOsname;
    [Token(Token = "0x4004FF5")]
    [FieldOffset(Offset = "0x2A")]
    [SerializeField]
    private bool bOkyakusamaCode;
    [Token(Token = "0x4004FF6")]
    [FieldOffset(Offset = "0x2B")]
    [SerializeField]
    private bool bUserAgent;
    [Token(Token = "0x4004FF7")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Image mImage;
    [Token(Token = "0x4004FF8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mText;

    [Token(Token = "0x6005AB7")]
    [Address(RVA = "0x12F7450", Offset = "0x12F6250", VA = "0x112F7450", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005AB8")]
    [Address(RVA = "0x12F7A90", Offset = "0x12F6890", VA = "0x112F7A90")]
    public static void SendLogMessage(
      FlowNode_SendLogMessage.SendLogGenerator dict,
      string tag,
      LogKit.Logger.Destination log_dir)
    {
    }

    [Token(Token = "0x6005AB9")]
    [Address(RVA = "0x12F7400", Offset = "0x12F6200", VA = "0x112F7400")]
    public static bool IsSetup() => new bool();

    [Token(Token = "0x6005ABA")]
    [Address(RVA = "0x12F7960", Offset = "0x12F6760", VA = "0x112F7960")]
    public static void SceneChangeEvent(string category, string before, string after)
    {
    }

    [Token(Token = "0x6005ABB")]
    [Address(RVA = "0x12F7C50", Offset = "0x12F6A50", VA = "0x112F7C50")]
    public static void TrackEvent(string category, string name)
    {
    }

    [Token(Token = "0x6005ABC")]
    [Address(RVA = "0x12F7B00", Offset = "0x12F6900", VA = "0x112F7B00")]
    public static void TrackEvent(string category, string name, int value)
    {
    }

    [Token(Token = "0x6005ABD")]
    [Address(RVA = "0x12F7D80", Offset = "0x12F6B80", VA = "0x112F7D80")]
    public static void TrackPurchase(string productId, string currency, double price = 0.0)
    {
    }

    [Token(Token = "0x6005ABE")]
    [Address(RVA = "0x12F77A0", Offset = "0x12F65A0", VA = "0x112F77A0")]
    public static void PurchaseFlow(string productId, string api, string status)
    {
    }

    [Token(Token = "0x6005ABF")]
    [Address(RVA = "0x12F7EE0", Offset = "0x12F6CE0", VA = "0x112F7EE0")]
    public static void TrackSpend(string category, string name, int value)
    {
    }

    [Token(Token = "0x6005AC0")]
    [Address(RVA = "0x12F8030", Offset = "0x12F6E30", VA = "0x112F8030")]
    public FlowNode_SendLogMessage()
    {
    }

    [Token(Token = "0x200160C")]
    public class SendLogGenerator
    {
      [Token(Token = "0x4004FF9")]
      [FieldOffset(Offset = "0x8")]
      private Dictionary<string, string> dict;

      [Token(Token = "0x6005AC1")]
      [Address(RVA = "0x1302750", Offset = "0x1301550", VA = "0x11302750")]
      public void Add(string tag, string msg)
      {
      }

      [Token(Token = "0x6005AC2")]
      [Address(RVA = "0x1302330", Offset = "0x1301130", VA = "0x11302330", Slot = "4")]
      public virtual void AddCommon(
        bool b_deviece_id,
        bool b_osname,
        bool b_okyakusama_code,
        bool b_user_agent)
      {
      }

      [Token(Token = "0x6005AC3")]
      [Address(RVA = "0x13025E0", Offset = "0x13013E0", VA = "0x113025E0")]
      public void AddOriginal(Image image, Text txt)
      {
      }

      [Token(Token = "0x6005AC4")]
      [Address(RVA = "0x13027E0", Offset = "0x13015E0", VA = "0x113027E0")]
      public string GetSendMessage() => (string) null;

      [Token(Token = "0x6005AC5")]
      [Address(RVA = "0x13029F0", Offset = "0x13017F0", VA = "0x113029F0")]
      public SendLogGenerator()
      {
      }
    }
  }
}
