// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONArray
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
  [Token(Token = "0x20036C6")]
  public class JSONArray : JSONNode, IEnumerable
  {
    [Token(Token = "0x4010164")]
    [FieldOffset(Offset = "0x8")]
    private List<JSONNode> m_List;

    [Token(Token = "0x1700239E")]
    public override JSONNode this[int aIndex]
    {
      [Token(Token = "0x600F7F6"), Address(RVA = "0xB6CC70", Offset = "0xB6BA70", VA = "0x10B6CC70", Slot = "5")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x600F7F7"), Address(RVA = "0xB6CD70", Offset = "0xB6BB70", VA = "0x10B6CD70", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x1700239F")]
    public override JSONNode this[string aKey]
    {
      [Token(Token = "0x600F7F8"), Address(RVA = "0xB6CC00", Offset = "0xB6BA00", VA = "0x10B6CC00", Slot = "7")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x600F7F9"), Address(RVA = "0xB6CD20", Offset = "0xB6BB20", VA = "0x10B6CD20", Slot = "8")] set
      {
      }
    }

    [Token(Token = "0x170023A0")]
    public override int Count
    {
      [Token(Token = "0x600F7FA"), Address(RVA = "0xB6CBC0", Offset = "0xB6B9C0", VA = "0x10B6CBC0", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F7FB")]
    [Address(RVA = "0xB6C4B0", Offset = "0xB6B2B0", VA = "0x10B6C4B0", Slot = "4")]
    public override void Add(string aKey, JSONNode aItem)
    {
    }

    [Token(Token = "0x600F7FC")]
    [Address(RVA = "0xB6C570", Offset = "0xB6B370", VA = "0x10B6C570", Slot = "14")]
    public override JSONNode Remove(int aIndex) => (JSONNode) null;

    [Token(Token = "0x600F7FD")]
    [Address(RVA = "0xB6C600", Offset = "0xB6B400", VA = "0x10B6C600", Slot = "15")]
    public override JSONNode Remove(JSONNode aNode) => (JSONNode) null;

    [Token(Token = "0x170023A1")]
    public override IEnumerable<JSONNode> Childs
    {
      [Token(Token = "0x600F7FE"), Address(RVA = "0xB6CB50", Offset = "0xB6B950", VA = "0x10B6CB50", Slot = "16")] get
      {
        return (IEnumerable<JSONNode>) null;
      }
    }

    [Token(Token = "0x600F7FF")]
    [Address(RVA = "0xB6C500", Offset = "0xB6B300", VA = "0x10B6C500", Slot = "29")]
    public IEnumerator GetEnumerator() => (IEnumerator) null;

    [Token(Token = "0x600F800")]
    [Address(RVA = "0xB6C720", Offset = "0xB6B520", VA = "0x10B6C720", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F801")]
    [Address(RVA = "0xB6C8D0", Offset = "0xB6B6D0", VA = "0x10B6C8D0", Slot = "17")]
    public override string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x600F802")]
    [Address(RVA = "0xB6C650", Offset = "0xB6B450", VA = "0x10B6C650", Slot = "28")]
    public override void Serialize(BinaryWriter aWriter)
    {
    }

    [Token(Token = "0x600F803")]
    [Address(RVA = "0xB6CAE0", Offset = "0xB6B8E0", VA = "0x10B6CAE0")]
    public JSONArray()
    {
    }
  }
}
