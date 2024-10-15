// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_Yuremono
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200125C")]
  [EventActionInfo("New/アクター/揺れもの切替", "アクターの揺れもの状態を切り替えます。", 6702148, 11158596)]
  public class EventAction_Yuremono : EventAction
  {
    [Token(Token = "0x40043A4")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;
    [Token(Token = "0x40043A5")]
    [FieldOffset(Offset = "0x1C")]
    public bool EnableYuremono;

    [Token(Token = "0x6004DC3")]
    [Address(RVA = "0x12328B0", Offset = "0x12316B0", VA = "0x112328B0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004DC4")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_Yuremono()
    {
    }
  }
}
