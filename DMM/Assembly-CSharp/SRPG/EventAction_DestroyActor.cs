// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_DestroyActor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011F5")]
  [EventActionInfo("New/アクター/削除", "指定のアクターを削除します。", 6702148, 11158596)]
  public class EventAction_DestroyActor : EventAction
  {
    [Token(Token = "0x4004152")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;

    [Token(Token = "0x6004C50")]
    [Address(RVA = "0x1216CE0", Offset = "0x1215AE0", VA = "0x11216CE0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C51")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public EventAction_DestroyActor()
    {
    }
  }
}
