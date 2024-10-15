// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_WaitAsyncAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001259")]
  [EventActionInfo("New/同期(アニメーション)", "非同期アニメーションが完了するのを待ちます", 5592405, 4473992)]
  public class EventAction_WaitAsyncAnimation : EventAction
  {
    [Token(Token = "0x400439E")]
    [FieldOffset(Offset = "0x18")]
    [StringIsActorList]
    public string ActorID;

    [Token(Token = "0x6004DB5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004DB6")]
    [Address(RVA = "0x12325B0", Offset = "0x12313B0", VA = "0x112325B0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004DB7")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public EventAction_WaitAsyncAnimation()
    {
    }
  }
}
