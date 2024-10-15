// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONClass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036C9")]
  public class JSONClass : JSONNode, IEnumerable
  {
    [Token(Token = "0x401016E")]
    [FieldOffset(Offset = "0x8")]
    private Dictionary<string, JSONNode> m_Dict;

    [Token(Token = "0x170023A6")]
    public override JSONNode this[string aKey]
    {
      [Token(Token = "0x600F814"), Address(RVA = "0xB6DCD0", Offset = "0xB6CAD0", VA = "0x10B6DCD0", Slot = "7")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x600F815"), Address(RVA = "0xB6DD90", Offset = "0xB6CB90", VA = "0x10B6DD90", Slot = "8")] set
      {
      }
    }

    [Token(Token = "0x170023A7")]
    public override JSONNode this[int aIndex]
    {
      [Token(Token = "0x600F816"), Address(RVA = "0xB6DC40", Offset = "0xB6CA40", VA = "0x10B6DC40", Slot = "5")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x600F817"), Address(RVA = "0xB6DE30", Offset = "0xB6CC30", VA = "0x10B6DE30", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x170023A8")]
    public override int Count
    {
      [Token(Token = "0x600F818"), Address(RVA = "0xB6DC00", Offset = "0xB6CA00", VA = "0x10B6DC00", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F819")]
    [Address(RVA = "0xB6CDF0", Offset = "0xB6BBF0", VA = "0x10B6CDF0", Slot = "4")]
    public override void Add(string aKey, JSONNode aItem)
    {
    }

    [Token(Token = "0x600F81A")]
    [Address(RVA = "0xB6D000", Offset = "0xB6BE00", VA = "0x10B6D000", Slot = "13")]
    public override JSONNode Remove(string aKey) => (JSONNode) null;

    [Token(Token = "0x600F81B")]
    [Address(RVA = "0xB6CF50", Offset = "0xB6BD50", VA = "0x10B6CF50", Slot = "14")]
    public override JSONNode Remove(int aIndex) => (JSONNode) null;

    [Token(Token = "0x600F81C")]
    [Address(RVA = "0xB6D0A0", Offset = "0xB6BEA0", VA = "0x10B6D0A0", Slot = "15")]
    public override JSONNode Remove(JSONNode aNode) => (JSONNode) null;

    [Token(Token = "0x170023A9")]
    public override IEnumerable<JSONNode> Childs
    {
      [Token(Token = "0x600F81D"), Address(RVA = "0xB6DB90", Offset = "0xB6C990", VA = "0x10B6DB90", Slot = "16")] get
      {
        return (IEnumerable<JSONNode>) null;
      }
    }

    [Token(Token = "0x600F81E")]
    [Address(RVA = "0xB6CEE0", Offset = "0xB6BCE0", VA = "0x10B6CEE0", Slot = "29")]
    public IEnumerator GetEnumerator() => (IEnumerator) null;

    [Token(Token = "0x600F81F")]
    [Address(RVA = "0xB6D440", Offset = "0xB6C240", VA = "0x10B6D440", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F820")]
    [Address(RVA = "0xB6D780", Offset = "0xB6C580", VA = "0x10B6D780", Slot = "17")]
    public override string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x600F821")]
    [Address(RVA = "0xB6D250", Offset = "0xB6C050", VA = "0x10B6D250", Slot = "28")]
    public override void Serialize(BinaryWriter aWriter)
    {
    }

    [Token(Token = "0x600F822")]
    [Address(RVA = "0xB6DB20", Offset = "0xB6C920", VA = "0x10B6DB20")]
    public JSONClass()
    {
    }
  }
}
