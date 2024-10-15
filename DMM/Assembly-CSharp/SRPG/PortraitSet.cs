// Decompiled with JetBrains decompiler
// Type: SRPG.PortraitSet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010B5")]
  public class PortraitSet : ScriptableObject
  {
    [Token(Token = "0x4003BF6")]
    [FieldOffset(Offset = "0xC")]
    public Texture2D Normal;
    [Token(Token = "0x4003BF7")]
    [FieldOffset(Offset = "0x10")]
    public Texture2D Smile;
    [Token(Token = "0x4003BF8")]
    [FieldOffset(Offset = "0x14")]
    public Texture2D Sad;
    [Token(Token = "0x4003BF9")]
    [FieldOffset(Offset = "0x18")]
    public Texture2D Angry;

    [Token(Token = "0x60046CE")]
    [Address(RVA = "0x11E2D60", Offset = "0x11E1B60", VA = "0x111E2D60")]
    public Texture2D GetEmotionImage(PortraitSet.EmotionTypes type) => (Texture2D) null;

    [Token(Token = "0x60046CF")]
    [Address(RVA = "0x2CE1D0", Offset = "0x2CCFD0", VA = "0x102CE1D0")]
    public PortraitSet()
    {
    }

    [Token(Token = "0x20010B6")]
    public enum EmotionTypes
    {
      [Token(Token = "0x4003BFB")] Normal,
      [Token(Token = "0x4003BFC")] Smile,
      [Token(Token = "0x4003BFD")] Sad,
      [Token(Token = "0x4003BFE")] Angry,
    }
  }
}
