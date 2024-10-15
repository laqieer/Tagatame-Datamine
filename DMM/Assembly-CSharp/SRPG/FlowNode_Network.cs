// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_Network
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200143B")]
  [FlowNode.Pin(99999, "HasCommonError==true", FlowNode.PinTypes.Output, 99999)]
  [FlowNode.Pin(10008, "API呼び出し前の状態に戻る", FlowNode.PinTypes.Output, 10008)]
  [FlowNode.Pin(10007, "リトライ", FlowNode.PinTypes.Output, 10007)]
  [FlowNode.Pin(10006, "API呼び出しパラメータ不正", FlowNode.PinTypes.Output, 10006)]
  [FlowNode.Pin(10005, "セッションID無効", FlowNode.PinTypes.Output, 10005)]
  [FlowNode.Pin(10003, "メンテナンス中", FlowNode.PinTypes.Output, 10003)]
  [FlowNode.Pin(10002, "通信エラー", FlowNode.PinTypes.Output, 10002)]
  [FlowNode.Pin(10001, "タイムアウト", FlowNode.PinTypes.Output, 10001)]
  [FlowNode.Pin(10004, "バージョン不一致", FlowNode.PinTypes.Output, 10004)]
  public abstract class FlowNode_Network : FlowNode
  {
    [Token(Token = "0x4004AE6")]
    private const int PIN_OUT_HAS_COMMON_ERROR = 99999;
    [Token(Token = "0x4004AE7")]
    public const string RetryWindowPrefabPath = "e/UI/NetworkRetryWindow";
    [Token(Token = "0x4004AE8")]
    [FieldOffset(Offset = "0x18")]
    private EncodingTypes.ESerializeCompressMethod __serializeCompressMethod;
    [Token(Token = "0x4004AE9")]
    [FieldOffset(Offset = "0x1C")]
    private StateMachine<FlowNode_Network> mStateMachine;

    [Token(Token = "0x17000928")]
    protected EncodingTypes.ESerializeCompressMethod SerializeCompressMethod
    {
      [Token(Token = "0x6005470"), Address(RVA = "0x12927B0", Offset = "0x12915B0", VA = "0x112927B0")] get
      {
        return new EncodingTypes.ESerializeCompressMethod();
      }
      [Token(Token = "0x6005471"), Address(RVA = "0x292D50", Offset = "0x291B50", VA = "0x10292D50")] set
      {
      }
    }

    [Token(Token = "0x6005472")]
    [Address(RVA = "0x1291BD0", Offset = "0x12909D0", VA = "0x11291BD0")]
    public bool IsJsonSerialize() => new bool();

    [Token(Token = "0x6005473")]
    [Address(RVA = "0x1291680", Offset = "0x1290480", VA = "0x11291680")]
    public CompressMode GetCompressMode() => new CompressMode();

    [Token(Token = "0x6005474")]
    [Address(RVA = "0x12914E0", Offset = "0x12902E0", VA = "0x112914E0")]
    public void ExecRequest(WebAPI api)
    {
    }

    [Token(Token = "0x6005475")]
    [Address(RVA = "0x1292610", Offset = "0x1291410", VA = "0x11292610")]
    private void Update()
    {
    }

    [Token(Token = "0x6005476")]
    [Address(RVA = "0x12916E0", Offset = "0x12904E0", VA = "0x112916E0")]
    public static bool HasCommonError(WWWResult www) => new bool();

    [Token(Token = "0x6005477")]
    [Address(RVA = "0x1292100", Offset = "0x1290F00", VA = "0x11292100")]
    public void ResponseCallback(WWWResult www)
    {
    }

    [Token(Token = "0x17000929")]
    public int OnTimeOutPinIndex
    {
      [Token(Token = "0x6005478"), Address(RVA = "0x1292790", Offset = "0x1291590", VA = "0x11292790")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700092A")]
    public int OnFailedPinIndex
    {
      [Token(Token = "0x6005479"), Address(RVA = "0x1292740", Offset = "0x1291540", VA = "0x11292740")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700092B")]
    public int OnMaintenancePinIndex
    {
      [Token(Token = "0x600547A"), Address(RVA = "0x1292760", Offset = "0x1291560", VA = "0x11292760")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700092C")]
    public int OnVersionPinIndex
    {
      [Token(Token = "0x600547B"), Address(RVA = "0x12927A0", Offset = "0x12915A0", VA = "0x112927A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700092D")]
    public int OnSessionIDPinIndex
    {
      [Token(Token = "0x600547C"), Address(RVA = "0x1292780", Offset = "0x1291580", VA = "0x11292780")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700092E")]
    public int OnIllegalParamPinIndex
    {
      [Token(Token = "0x600547D"), Address(RVA = "0x1292750", Offset = "0x1291550", VA = "0x11292750")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700092F")]
    public int OnRetryPinIndex
    {
      [Token(Token = "0x600547E"), Address(RVA = "0x1292770", Offset = "0x1291570", VA = "0x11292770")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000930")]
    public int OnBackPinIndex
    {
      [Token(Token = "0x600547F"), Address(RVA = "0x1292730", Offset = "0x1291530", VA = "0x11292730")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6005480")]
    [Address(RVA = "0x1292590", Offset = "0x1291390", VA = "0x11292590")]
    public static void TimeOut()
    {
    }

    [Token(Token = "0x6005481")]
    [Address(RVA = "0x1291F30", Offset = "0x1290D30", VA = "0x11291F30", Slot = "13")]
    public virtual void OnTimeOut()
    {
    }

    [Token(Token = "0x6005482")]
    [Address(RVA = "0x12915A0", Offset = "0x12903A0", VA = "0x112915A0")]
    public static void Failed()
    {
    }

    [Token(Token = "0x6005483")]
    [Address(RVA = "0x1291E40", Offset = "0x1290C40", VA = "0x11291E40", Slot = "14")]
    public virtual void OnFailed()
    {
    }

    [Token(Token = "0x6005484")]
    [Address(RVA = "0x1291C30", Offset = "0x1290A30", VA = "0x11291C30")]
    public static void Maintenance()
    {
    }

    [Token(Token = "0x6005485")]
    [Address(RVA = "0x1291EA0", Offset = "0x1290CA0", VA = "0x11291EA0", Slot = "15")]
    public virtual void OnMaintenance()
    {
    }

    [Token(Token = "0x6005486")]
    [Address(RVA = "0x1292650", Offset = "0x1291450", VA = "0x11292650")]
    public static void Version()
    {
    }

    [Token(Token = "0x6005487")]
    [Address(RVA = "0x1291FD0", Offset = "0x1290DD0", VA = "0x11291FD0", Slot = "16")]
    public virtual void OnVersion()
    {
    }

    [Token(Token = "0x6005488")]
    [Address(RVA = "0x12924D0", Offset = "0x12912D0", VA = "0x112924D0")]
    public static void SessionID()
    {
    }

    [Token(Token = "0x6005489")]
    [Address(RVA = "0x1292000", Offset = "0x1290E00", VA = "0x11292000")]
    public static void Relogin()
    {
    }

    [Token(Token = "0x600548A")]
    [Address(RVA = "0x1291E10", Offset = "0x1290C10", VA = "0x11291E10", Slot = "17")]
    public virtual void OnSessionID()
    {
    }

    [Token(Token = "0x600548B")]
    [Address(RVA = "0x1291B70", Offset = "0x1290970", VA = "0x11291B70")]
    public static void IllegalParam()
    {
    }

    [Token(Token = "0x600548C")]
    [Address(RVA = "0x1291E70", Offset = "0x1290C70", VA = "0x11291E70", Slot = "18")]
    public virtual void OnIllegalParam()
    {
    }

    [Token(Token = "0x600548D")]
    [Address(RVA = "0x1291F00", Offset = "0x1290D00", VA = "0x11291F00")]
    protected void OnRetry(Exception reason)
    {
    }

    [Token(Token = "0x600548E")]
    [Address(RVA = "0x12921F0", Offset = "0x1290FF0", VA = "0x112921F0")]
    public static void Retry()
    {
    }

    [Token(Token = "0x600548F")]
    [Address(RVA = "0x1291ED0", Offset = "0x1290CD0", VA = "0x11291ED0", Slot = "19")]
    public virtual void OnRetry()
    {
    }

    [Token(Token = "0x6005490")]
    [Address(RVA = "0x1292170", Offset = "0x1290F70", VA = "0x11292170")]
    private static void RetryEvent(bool retry)
    {
    }

    [Token(Token = "0x6005491")]
    [Address(RVA = "0x12912C0", Offset = "0x12900C0", VA = "0x112912C0")]
    public static void Back()
    {
    }

    [Token(Token = "0x6005492")]
    [Address(RVA = "0x1291D10", Offset = "0x1290B10", VA = "0x11291D10", Slot = "20")]
    public virtual void OnBack()
    {
    }

    [Token(Token = "0x6005493")]
    [Address(RVA = "0x12913A0", Offset = "0x12901A0", VA = "0x112913A0")]
    public static void CloseWebView()
    {
    }

    [Token(Token = "0x6005494")]
    public abstract void OnSuccess(WWWResult www);

    [Token(Token = "0x6005495")]
    [Address(RVA = "0x1291420", Offset = "0x1290220", VA = "0x11291420")]
    public static void ErrorAppQuit()
    {
    }

    [Token(Token = "0x6005496")]
    [Address(RVA = "0x1291E10", Offset = "0x1290C10", VA = "0x11291E10", Slot = "22")]
    public virtual void OnErrorAppQuit()
    {
    }

    [Token(Token = "0x6005497")]
    [Address(RVA = "0x12923A0", Offset = "0x12911A0", VA = "0x112923A0")]
    public static void ServerNotify(SRPG.Network.EErrCode error)
    {
    }

    [Token(Token = "0x6005498")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    protected FlowNode_Network()
    {
    }

    [Token(Token = "0x200143C")]
    private class State_WaitForConnect : State<FlowNode_Network>
    {
      [Token(Token = "0x6005499")]
      [Address(RVA = "0x12A00A0", Offset = "0x129EEA0", VA = "0x112A00A0", Slot = "5")]
      public override void Update(FlowNode_Network self)
      {
      }

      [Token(Token = "0x600549A")]
      [Address(RVA = "0x12A00E0", Offset = "0x129EEE0", VA = "0x112A00E0")]
      public State_WaitForConnect()
      {
      }
    }
  }
}
