// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_WaitSeconds
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200125A")]
  [EventActionInfo("待機/秒数を指定", "指定した時間の間スクリプトの実行を停止します。", 5592405, 4473992)]
  public class EventAction_WaitSeconds : EventAction
  {
    [Token(Token = "0x400439F")]
    [FieldOffset(Offset = "0x18")]
    public float WaitSeconds;
    [Token(Token = "0x40043A0")]
    [FieldOffset(Offset = "0x1C")]
    private float mTimer;

    [Token(Token = "0x6004DB8")]
    [Address(RVA = "0x1232780", Offset = "0x1231580", VA = "0x11232780", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004DB9")]
    [Address(RVA = "0x1232790", Offset = "0x1231590", VA = "0x11232790", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004DBA")]
    [Address(RVA = "0x1197FF0", Offset = "0x1196DF0", VA = "0x11197FF0", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004DBB")]
    [Address(RVA = "0x1197FF0", Offset = "0x1196DF0", VA = "0x11197FF0", Slot = "10")]
    public override void SkipImmediate()
    {
    }

    [Token(Token = "0x6004DBC")]
    [Address(RVA = "0x12327E0", Offset = "0x12315E0", VA = "0x112327E0")]
    public EventAction_WaitSeconds()
    {
    }
  }
}
