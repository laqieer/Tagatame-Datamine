// Decompiled with JetBrains decompiler
// Type: SRPG.ColorUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002364")]
  public static class ColorUtility
  {
    [Token(Token = "0x4009EBE")]
    [FieldOffset(Offset = "0x0")]
    private static Dictionary<string, Color32> mNamedColors;

    [Token(Token = "0x60098A0")]
    [Address(RVA = "0x5A9000", Offset = "0x5A7E00", VA = "0x105A9000")]
    static ColorUtility()
    {
    }

    [Token(Token = "0x60098A1")]
    [Address(RVA = "0x5A8DE0", Offset = "0x5A7BE0", VA = "0x105A8DE0")]
    public static Color32 GetColor(string name) => new Color32();

    [Token(Token = "0x60098A2")]
    [Address(RVA = "0x5A8EA0", Offset = "0x5A7CA0", VA = "0x105A8EA0")]
    public static Color32 ParseColor(string src) => new Color32();
  }
}
