// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_CameraShake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011F3")]
  [EventActionInfo("カメラ/シェイク", "画面を揺らします。", 5592405, 4473992)]
  public class EventAction_CameraShake : EventAction
  {
    [Token(Token = "0x4004147")]
    [FieldOffset(Offset = "0x18")]
    public float Duration;
    [Token(Token = "0x4004148")]
    [FieldOffset(Offset = "0x1C")]
    public float FrequencyX;
    [Token(Token = "0x4004149")]
    [FieldOffset(Offset = "0x20")]
    public float FrequencyY;
    [Token(Token = "0x400414A")]
    [FieldOffset(Offset = "0x24")]
    public float AmplitudeX;
    [Token(Token = "0x400414B")]
    [FieldOffset(Offset = "0x28")]
    public float AmplitudeY;
    [Token(Token = "0x400414C")]
    [FieldOffset(Offset = "0x2C")]
    public bool Async;

    [Token(Token = "0x6004C4A")]
    [Address(RVA = "0x12167D0", Offset = "0x12155D0", VA = "0x112167D0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004C4B")]
    [Address(RVA = "0x12168A0", Offset = "0x12156A0", VA = "0x112168A0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004C4C")]
    [Address(RVA = "0x12168F0", Offset = "0x12156F0", VA = "0x112168F0")]
    public EventAction_CameraShake()
    {
    }
  }
}
