// Decompiled with JetBrains decompiler
// Type: SRPG.LocalVariable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20018B8")]
  [AddComponentMenu("/LocalVariable")]
  [DisallowMultipleComponent]
  public class LocalVariable : MonoBehaviour
  {
    [Token(Token = "0x400589E")]
    [FieldOffset(Offset = "0xC")]
    private Dictionary<string, string> mVariables;

    [Token(Token = "0x600635E")]
    [Address(RVA = "0x3169F0", Offset = "0x3157F0", VA = "0x103169F0")]
    public bool Exists(string key) => new bool();

    [Token(Token = "0x600635F")]
    [Address(RVA = "0x316A40", Offset = "0x315840", VA = "0x10316A40")]
    public void Set(string key, string val)
    {
    }

    [Token(Token = "0x6006360")]
    [Address(RVA = "0x316960", Offset = "0x315760", VA = "0x10316960")]
    public bool Equal(string key, string val) => new bool();

    [Token(Token = "0x6006361")]
    [Address(RVA = "0x316AF0", Offset = "0x3158F0", VA = "0x10316AF0")]
    public LocalVariable()
    {
    }
  }
}
