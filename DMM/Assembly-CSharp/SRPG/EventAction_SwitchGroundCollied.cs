// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SwitchGroundCollied
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001250")]
  [EventActionInfo("New/アクター/地面判定切り替え", "指定のアクターの地面判定を切り替えます。", 5592405, 4473992)]
  public class EventAction_SwitchGroundCollied : EventAction
  {
    [Token(Token = "0x4004381")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x4004382")]
    [FieldOffset(Offset = "0x1C")]
    public bool GroundSnap;

    [Token(Token = "0x6004D98")]
    [Address(RVA = "0x1231CA0", Offset = "0x1230AA0", VA = "0x11231CA0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D99")]
    [Address(RVA = "0x1231D40", Offset = "0x1230B40", VA = "0x11231D40")]
    public EventAction_SwitchGroundCollied()
    {
    }
  }
}
