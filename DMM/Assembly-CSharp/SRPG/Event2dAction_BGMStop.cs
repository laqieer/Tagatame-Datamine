// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_BGMStop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200127B")]
  [EventActionInfo("New/BGM停止(2D)", "BGMを停止します", 5592405, 4473992)]
  public class Event2dAction_BGMStop : EventAction
  {
    [Token(Token = "0x4004425")]
    [FieldOffset(Offset = "0x18")]
    public bool Async;
    [Token(Token = "0x4004426")]
    [FieldOffset(Offset = "0x1C")]
    public float fadeOutTime;
    [Token(Token = "0x4004427")]
    [FieldOffset(Offset = "0x20")]
    private float elapsedtime;
    [Token(Token = "0x4004428")]
    [FieldOffset(Offset = "0x24")]
    private Event2dAction_BGMStop.STOP_STATE state;

    [Token(Token = "0x6004E41")]
    [Address(RVA = "0x1227C00", Offset = "0x1226A00", VA = "0x11227C00", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E42")]
    [Address(RVA = "0x1227C20", Offset = "0x1226A20", VA = "0x11227C20", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004E43")]
    [Address(RVA = "0x1227D90", Offset = "0x1226B90", VA = "0x11227D90")]
    public Event2dAction_BGMStop()
    {
    }

    [Token(Token = "0x200127C")]
    private enum STOP_STATE
    {
      [Token(Token = "0x400442A")] PREPARE,
      [Token(Token = "0x400442B")] STOPPING,
      [Token(Token = "0x400442C")] STOPPED,
    }
  }
}
