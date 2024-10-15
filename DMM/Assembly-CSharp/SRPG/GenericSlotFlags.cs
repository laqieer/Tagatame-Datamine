// Decompiled with JetBrains decompiler
// Type: SRPG.GenericSlotFlags
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20024D9")]
  [DisallowMultipleComponent]
  [AddComponentMenu("UI/GenericSlotFlags")]
  public class GenericSlotFlags : MonoBehaviour
  {
    [Token(Token = "0x400A83E")]
    [FieldOffset(Offset = "0xC")]
    [BitMask]
    public GenericSlotFlags.VisibleFlags Flags;

    [Token(Token = "0x600A1B5")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenericSlotFlags()
    {
    }

    [Token(Token = "0x20024DA")]
    [System.Flags]
    public enum VisibleFlags
    {
      [Token(Token = "0x400A840")] Empty = 1,
      [Token(Token = "0x400A841")] NonEmpty = 2,
      [Token(Token = "0x400A842")] Locked = 4,
    }
  }
}
