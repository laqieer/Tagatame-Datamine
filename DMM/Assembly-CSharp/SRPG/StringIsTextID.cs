// Decompiled with JetBrains decompiler
// Type: SRPG.StringIsTextID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001141")]
  public class StringIsTextID : PropertyAttribute
  {
    [Token(Token = "0x4003ED3")]
    [FieldOffset(Offset = "0xC")]
    public bool ContainsVoiceID;

    [Token(Token = "0x60049E0")]
    [Address(RVA = "0xF4FEA0", Offset = "0xF4ECA0", VA = "0x10F4FEA0")]
    public StringIsTextID(bool containsVoiceID = false)
    {
    }
  }
}
