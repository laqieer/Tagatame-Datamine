// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using System.IO;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036C3")]
  public class JSONNode
  {
    [Token(Token = "0x600F7B6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public virtual void Add(string aKey, JSONNode aItem)
    {
    }

    [Token(Token = "0x1700238E")]
    public virtual JSONNode this[int aIndex]
    {
      [Token(Token = "0x600F7B7"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "5")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x600F7B8"), Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x1700238F")]
    public virtual JSONNode this[string aKey]
    {
      [Token(Token = "0x600F7B9"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "7")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x600F7BA"), Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")] set
      {
      }
    }

    [Token(Token = "0x17002390")]
    public virtual string Value
    {
      [Token(Token = "0x600F7BB"), Address(RVA = "0xB70080", Offset = "0xB6EE80", VA = "0x10B70080", Slot = "9")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F7BC"), Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "10")] set
      {
      }
    }

    [Token(Token = "0x17002391")]
    public virtual int Count
    {
      [Token(Token = "0x600F7BD"), Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "11")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600F7BE")]
    [Address(RVA = "0xB6EBD0", Offset = "0xB6D9D0", VA = "0x10B6EBD0", Slot = "12")]
    public virtual void Add(JSONNode aItem)
    {
    }

    [Token(Token = "0x600F7BF")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "13")]
    public virtual JSONNode Remove(string aKey) => (JSONNode) null;

    [Token(Token = "0x600F7C0")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0", Slot = "14")]
    public virtual JSONNode Remove(int aIndex) => (JSONNode) null;

    [Token(Token = "0x600F7C1")]
    [Address(RVA = "0x36C350", Offset = "0x36B150", VA = "0x1036C350", Slot = "15")]
    public virtual JSONNode Remove(JSONNode aNode) => (JSONNode) null;

    [Token(Token = "0x17002392")]
    public virtual IEnumerable<JSONNode> Childs
    {
      [Token(Token = "0x600F7C2"), Address(RVA = "0xB6FFB0", Offset = "0xB6EDB0", VA = "0x10B6FFB0", Slot = "16")] get
      {
        return (IEnumerable<JSONNode>) null;
      }
    }

    [Token(Token = "0x17002393")]
    public IEnumerable<JSONNode> DeepChilds
    {
      [Token(Token = "0x600F7C3"), Address(RVA = "0xB70010", Offset = "0xB6EE10", VA = "0x10B70010")] get
      {
        return (IEnumerable<JSONNode>) null;
      }
    }

    [Token(Token = "0x600F7C4")]
    [Address(RVA = "0xB6FD30", Offset = "0xB6EB30", VA = "0x10B6FD30", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F7C5")]
    [Address(RVA = "0xB6FD00", Offset = "0xB6EB00", VA = "0x10B6FD00", Slot = "17")]
    public virtual string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x17002394")]
    public virtual int AsInt
    {
      [Token(Token = "0x600F7C6"), Address(RVA = "0xB6FF00", Offset = "0xB6ED00", VA = "0x10B6FF00", Slot = "18")] get
      {
        return new int();
      }
      [Token(Token = "0x600F7C7"), Address(RVA = "0xB70300", Offset = "0xB6F100", VA = "0x10B70300", Slot = "19")] set
      {
      }
    }

    [Token(Token = "0x17002395")]
    public virtual float AsFloat
    {
      [Token(Token = "0x600F7C8"), Address(RVA = "0xB6FEC0", Offset = "0xB6ECC0", VA = "0x10B6FEC0", Slot = "20")] get
      {
        return new float();
      }
      [Token(Token = "0x600F7C9"), Address(RVA = "0xB702D0", Offset = "0xB6F0D0", VA = "0x10B702D0", Slot = "21")] set
      {
      }
    }

    [Token(Token = "0x17002396")]
    public virtual double AsDouble
    {
      [Token(Token = "0x600F7CA"), Address(RVA = "0xB6FE70", Offset = "0xB6EC70", VA = "0x10B6FE70", Slot = "22")] get
      {
        return new double();
      }
      [Token(Token = "0x600F7CB"), Address(RVA = "0xB702A0", Offset = "0xB6F0A0", VA = "0x10B702A0", Slot = "23")] set
      {
      }
    }

    [Token(Token = "0x17002397")]
    public virtual bool AsBool
    {
      [Token(Token = "0x600F7CC"), Address(RVA = "0xB6FDD0", Offset = "0xB6EBD0", VA = "0x10B6FDD0", Slot = "24")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F7CD"), Address(RVA = "0xB70240", Offset = "0xB6F040", VA = "0x10B70240", Slot = "25")] set
      {
      }
    }

    [Token(Token = "0x17002398")]
    public virtual JSONArray AsArray
    {
      [Token(Token = "0x600F7CE"), Address(RVA = "0xB6FD60", Offset = "0xB6EB60", VA = "0x10B6FD60", Slot = "26")] get
      {
        return (JSONArray) null;
      }
    }

    [Token(Token = "0x17002399")]
    public virtual JSONClass AsObject
    {
      [Token(Token = "0x600F7CF"), Address(RVA = "0xB6FF40", Offset = "0xB6ED40", VA = "0x10B6FF40", Slot = "27")] get
      {
        return (JSONClass) null;
      }
    }

    [Token(Token = "0x600F7D0")]
    [Address(RVA = "0xB70180", Offset = "0xB6EF80", VA = "0x10B70180")]
    public static implicit operator JSONNode(string s) => (JSONNode) null;

    [Token(Token = "0x600F7D1")]
    [Address(RVA = "0xB70110", Offset = "0xB6EF10", VA = "0x10B70110")]
    public static implicit operator string(JSONNode d) => (string) null;

    [Token(Token = "0x600F7D2")]
    [Address(RVA = "0xB700B0", Offset = "0xB6EEB0", VA = "0x10B700B0")]
    public static bool operator ==(JSONNode a, object b) => new bool();

    [Token(Token = "0x600F7D3")]
    [Address(RVA = "0xB701E0", Offset = "0xB6EFE0", VA = "0x10B701E0")]
    public static bool operator !=(JSONNode a, object b) => new bool();

    [Token(Token = "0x600F7D4")]
    [Address(RVA = "0xB2AE10", Offset = "0xB29C10", VA = "0x10B2AE10", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F7D5")]
    [Address(RVA = "0x36AC30", Offset = "0x369A30", VA = "0x1036AC30", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F7D6")]
    [Address(RVA = "0xB6EF80", Offset = "0xB6DD80", VA = "0x10B6EF80")]
    internal static string Escape(string aText) => (string) null;

    [Token(Token = "0x600F7D7")]
    [Address(RVA = "0xB6F420", Offset = "0xB6E220", VA = "0x10B6F420")]
    public static JSONNode Parse(string aJSON) => (JSONNode) null;

    [Token(Token = "0x600F7D8")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "28")]
    public virtual void Serialize(BinaryWriter aWriter)
    {
    }

    [Token(Token = "0x600F7D9")]
    [Address(RVA = "0xB6FC90", Offset = "0xB6EA90", VA = "0x10B6FC90")]
    public void SaveToStream(Stream aData)
    {
    }

    [Token(Token = "0x600F7DA")]
    [Address(RVA = "0xB6FC40", Offset = "0xB6EA40", VA = "0x10B6FC40")]
    public void SaveToCompressedStream(Stream aData)
    {
    }

    [Token(Token = "0x600F7DB")]
    [Address(RVA = "0xB6FBF0", Offset = "0xB6E9F0", VA = "0x10B6FBF0")]
    public void SaveToCompressedFile(string aFileName)
    {
    }

    [Token(Token = "0x600F7DC")]
    [Address(RVA = "0xB6FBA0", Offset = "0xB6E9A0", VA = "0x10B6FBA0")]
    public string SaveToCompressedBase64() => (string) null;

    [Token(Token = "0x600F7DD")]
    [Address(RVA = "0xB6EC20", Offset = "0xB6DA20", VA = "0x10B6EC20")]
    public static JSONNode Deserialize(BinaryReader aReader) => (JSONNode) null;

    [Token(Token = "0x600F7DE")]
    [Address(RVA = "0xB6F250", Offset = "0xB6E050", VA = "0x10B6F250")]
    public static JSONNode LoadFromCompressedFile(string aFileName) => (JSONNode) null;

    [Token(Token = "0x600F7DF")]
    [Address(RVA = "0xB6F2A0", Offset = "0xB6E0A0", VA = "0x10B6F2A0")]
    public static JSONNode LoadFromCompressedStream(Stream aData) => (JSONNode) null;

    [Token(Token = "0x600F7E0")]
    [Address(RVA = "0xB6F200", Offset = "0xB6E000", VA = "0x10B6F200")]
    public static JSONNode LoadFromCompressedBase64(string aBase64) => (JSONNode) null;

    [Token(Token = "0x600F7E1")]
    [Address(RVA = "0xB6F2F0", Offset = "0xB6E0F0", VA = "0x10B6F2F0")]
    public static JSONNode LoadFromStream(Stream aData) => (JSONNode) null;

    [Token(Token = "0x600F7E2")]
    [Address(RVA = "0xB6F160", Offset = "0xB6DF60", VA = "0x10B6F160")]
    public static JSONNode LoadFromBase64(string aBase64) => (JSONNode) null;

    [Token(Token = "0x600F7E3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSONNode()
    {
    }
  }
}
