// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SEStop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012A2")]
  [EventActionInfo("New/SE停止(2D)", "SEを停止します", 5592405, 4473992)]
  public class Event2dAction_SEStop : EventAction
  {
    [Token(Token = "0x4004547")]
    [FieldOffset(Offset = "0x18")]
    public string SE_ID;
    [Token(Token = "0x4004548")]
    [FieldOffset(Offset = "0x1C")]
    public bool Async;
    [Token(Token = "0x4004549")]
    [FieldOffset(Offset = "0x20")]
    public float fadeOutTime;
    [Token(Token = "0x400454A")]
    [FieldOffset(Offset = "0x24")]
    private float elapsedtime;
    [Token(Token = "0x400454B")]
    [FieldOffset(Offset = "0x28")]
    private Event2dAction_SELoop seloop;

    [Token(Token = "0x6004EF5")]
    [Address(RVA = "0x1242990", Offset = "0x1241790", VA = "0x11242990", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EF6")]
    [Address(RVA = "0x1242B90", Offset = "0x1241990", VA = "0x11242B90", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004EF7")]
    [Address(RVA = "0x1242C50", Offset = "0x1241A50", VA = "0x11242C50")]
    public Event2dAction_SEStop()
    {
    }
  }
}
