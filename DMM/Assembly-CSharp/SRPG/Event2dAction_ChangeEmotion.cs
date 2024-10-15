// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_ChangeEmotion
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200127D")]
  [EventActionInfo("New/立ち絵2/表情切替", "指定したキャラの表情を切り替えます。", 5592405, 4473992)]
  public class Event2dAction_ChangeEmotion : EventAction
  {
    [Token(Token = "0x400442D")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x400442E")]
    [FieldOffset(Offset = "0x1C")]
    public string Emotion;

    [Token(Token = "0x6004E44")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004E45")]
    [Address(RVA = "0x1227E00", Offset = "0x1226C00", VA = "0x11227E00", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004E46")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_ChangeEmotion()
    {
    }
  }
}
