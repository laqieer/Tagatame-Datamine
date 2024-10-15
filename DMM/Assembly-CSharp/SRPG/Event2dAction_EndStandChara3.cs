// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_EndStandChara3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200128B")]
  [EventActionInfo("New/立ち絵2/立ち絵消去2(2D)", "表示されている立ち絵を消します", 5592405, 4473992)]
  public class Event2dAction_EndStandChara3 : EventAction
  {
    [Token(Token = "0x400449C")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x400449D")]
    [FieldOffset(Offset = "0x1C")]
    public float FadeTime;
    [Token(Token = "0x400449E")]
    [FieldOffset(Offset = "0x20")]
    public bool Async;
    [Token(Token = "0x400449F")]
    [FieldOffset(Offset = "0x24")]
    private float mTimer;

    [Token(Token = "0x6004E93")]
    [Address(RVA = "0x123D6E0", Offset = "0x123C4E0", VA = "0x1123D6E0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E94")]
    [Address(RVA = "0x123D850", Offset = "0x123C650", VA = "0x1123D850", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004E95")]
    [Address(RVA = "0x1227D90", Offset = "0x1226B90", VA = "0x11227D90")]
    public Event2dAction_EndStandChara3()
    {
    }
  }
}
