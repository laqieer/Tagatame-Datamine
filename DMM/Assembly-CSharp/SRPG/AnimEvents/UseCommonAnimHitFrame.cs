// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEvents.UseCommonAnimHitFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.AnimEvents
{
  [Token(Token = "0x20032FC")]
  public class UseCommonAnimHitFrame : AnimEvent
  {
    [Token(Token = "0x400EFDC")]
    [FieldOffset(Offset = "0x18")]
    public float ComboInterval;
    [Token(Token = "0x400EFDD")]
    [FieldOffset(Offset = "0x1C")]
    public UseCommonAnimHitFrame.HitCase HitType;

    [Token(Token = "0x600DFCD")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public UseCommonAnimHitFrame()
    {
    }

    [Token(Token = "0x20032FD")]
    public enum HitCase
    {
      [Token(Token = "0x400EFDF")] Normal,
      [Token(Token = "0x400EFE0")] MoveAfter,
      [Token(Token = "0x400EFE1")] MoveBefore,
    }
  }
}
