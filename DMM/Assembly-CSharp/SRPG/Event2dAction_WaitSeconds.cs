// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_WaitSeconds
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012C0")]
  [EventActionInfo("待機/秒数を指定(2D)", "指定した時間の間スクリプトの実行を停止します。", 5592405, 4473992)]
  public class Event2dAction_WaitSeconds : EventAction
  {
    [Token(Token = "0x40045ED")]
    [FieldOffset(Offset = "0x18")]
    public float WaitSeconds;
    [Token(Token = "0x40045EE")]
    [FieldOffset(Offset = "0x1C")]
    private float mTimer;

    [Token(Token = "0x6004F7F")]
    [Address(RVA = "0x1232780", Offset = "0x1231580", VA = "0x11232780", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F80")]
    [Address(RVA = "0x1232790", Offset = "0x1231590", VA = "0x11232790", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004F81")]
    [Address(RVA = "0x12327E0", Offset = "0x12315E0", VA = "0x112327E0")]
    public Event2dAction_WaitSeconds()
    {
    }
  }
}
