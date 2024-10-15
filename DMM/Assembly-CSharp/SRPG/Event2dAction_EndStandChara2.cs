// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_EndStandChara2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200128A")]
  [EventActionInfo("立ち絵2/立ち絵消去(2D)", "表示されている立ち絵を消します", 5592405, 4473992)]
  public class Event2dAction_EndStandChara2 : EventAction
  {
    [Token(Token = "0x4004499")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x400449A")]
    private const float WAIT_SECONDS = 1f;
    [Token(Token = "0x400449B")]
    [FieldOffset(Offset = "0x1C")]
    private float mTimer;

    [Token(Token = "0x6004E90")]
    [Address(RVA = "0x123D590", Offset = "0x123C390", VA = "0x1123D590", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E91")]
    [Address(RVA = "0x1232790", Offset = "0x1231590", VA = "0x11232790", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004E92")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_EndStandChara2()
    {
    }
  }
}
