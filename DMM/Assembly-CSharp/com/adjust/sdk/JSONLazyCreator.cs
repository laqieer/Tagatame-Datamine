// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.JSONLazyCreator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036CE")]
  internal class JSONLazyCreator : JSONNode
  {
    [Token(Token = "0x401017A")]
    [FieldOffset(Offset = "0x8")]
    private JSONNode m_Node;
    [Token(Token = "0x401017B")]
    [FieldOffset(Offset = "0xC")]
    private string m_Key;

    [Token(Token = "0x600F83F")]
    [Address(RVA = "0xB6E530", Offset = "0xB6D330", VA = "0x10B6E530")]
    public JSONLazyCreator(JSONNode aNode)
    {
    }

    [Token(Token = "0x600F840")]
    [Address(RVA = "0x3C0020", Offset = "0x3BEE20", VA = "0x103C0020")]
    public JSONLazyCreator(JSONNode aNode, string aKey)
    {
    }

    [Token(Token = "0x600F841")]
    [Address(RVA = "0xB6E450", Offset = "0xB6D250", VA = "0x10B6E450")]
    private void Set(JSONNode aVal)
    {
    }

    [Token(Token = "0x170023AF")]
    public override JSONNode this[int aIndex]
    {
      [Token(Token = "0x600F842"), Address(RVA = "0xB6E810", Offset = "0xB6D610", VA = "0x10B6E810", Slot = "5")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x600F843"), Address(RVA = "0xB6EAF0", Offset = "0xB6D8F0", VA = "0x10B6EAF0", Slot = "6")] set
      {
      }
    }

    [Token(Token = "0x170023B0")]
    public override JSONNode this[string aKey]
    {
      [Token(Token = "0x600F844"), Address(RVA = "0xB6E880", Offset = "0xB6D680", VA = "0x10B6E880", Slot = "7")] get
      {
        return (JSONNode) null;
      }
      [Token(Token = "0x600F845"), Address(RVA = "0xB6EB60", Offset = "0xB6D960", VA = "0x10B6EB60", Slot = "8")] set
      {
      }
    }

    [Token(Token = "0x600F846")]
    [Address(RVA = "0xB6E350", Offset = "0xB6D150", VA = "0x10B6E350", Slot = "12")]
    public override void Add(JSONNode aItem)
    {
    }

    [Token(Token = "0x600F847")]
    [Address(RVA = "0xB6E3C0", Offset = "0xB6D1C0", VA = "0x10B6E3C0", Slot = "4")]
    public override void Add(string aKey, JSONNode aItem)
    {
    }

    [Token(Token = "0x600F848")]
    [Address(RVA = "0xB6E430", Offset = "0xB6D230", VA = "0x10B6E430")]
    public static bool operator ==(JSONLazyCreator a, object b) => new bool();

    [Token(Token = "0x600F849")]
    [Address(RVA = "0xB6E8F0", Offset = "0xB6D6F0", VA = "0x10B6E8F0")]
    public static bool operator !=(JSONLazyCreator a, object b) => new bool();

    [Token(Token = "0x600F84A")]
    [Address(RVA = "0xB6E430", Offset = "0xB6D230", VA = "0x10B6E430", Slot = "0")]
    public override bool Equals(object obj) => new bool();

    [Token(Token = "0x600F84B")]
    [Address(RVA = "0x36AC30", Offset = "0x369A30", VA = "0x1036AC30", Slot = "2")]
    public override int GetHashCode() => new int();

    [Token(Token = "0x600F84C")]
    [Address(RVA = "0xB6E4D0", Offset = "0xB6D2D0", VA = "0x10B6E4D0", Slot = "3")]
    public override string ToString() => (string) null;

    [Token(Token = "0x600F84D")]
    [Address(RVA = "0xB6E500", Offset = "0xB6D300", VA = "0x10B6E500", Slot = "17")]
    public override string ToString(string aPrefix) => (string) null;

    [Token(Token = "0x170023B1")]
    public override int AsInt
    {
      [Token(Token = "0x600F84E"), Address(RVA = "0xB6E740", Offset = "0xB6D540", VA = "0x10B6E740", Slot = "18")] get
      {
        return new int();
      }
      [Token(Token = "0x600F84F"), Address(RVA = "0xB6EA80", Offset = "0xB6D880", VA = "0x10B6EA80", Slot = "19")] set
      {
      }
    }

    [Token(Token = "0x170023B2")]
    public override float AsFloat
    {
      [Token(Token = "0x600F850"), Address(RVA = "0xB6E6C0", Offset = "0xB6D4C0", VA = "0x10B6E6C0", Slot = "20")] get
      {
        return new float();
      }
      [Token(Token = "0x600F851"), Address(RVA = "0xB6EA00", Offset = "0xB6D800", VA = "0x10B6EA00", Slot = "21")] set
      {
      }
    }

    [Token(Token = "0x170023B3")]
    public override double AsDouble
    {
      [Token(Token = "0x600F852"), Address(RVA = "0xB6E640", Offset = "0xB6D440", VA = "0x10B6E640", Slot = "22")] get
      {
        return new double();
      }
      [Token(Token = "0x600F853"), Address(RVA = "0xB6E980", Offset = "0xB6D780", VA = "0x10B6E980", Slot = "23")] set
      {
      }
    }

    [Token(Token = "0x170023B4")]
    public override bool AsBool
    {
      [Token(Token = "0x600F854"), Address(RVA = "0xB6E5D0", Offset = "0xB6D3D0", VA = "0x10B6E5D0", Slot = "24")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F855"), Address(RVA = "0xB6E910", Offset = "0xB6D710", VA = "0x10B6E910", Slot = "25")] set
      {
      }
    }

    [Token(Token = "0x170023B5")]
    public override JSONArray AsArray
    {
      [Token(Token = "0x600F856"), Address(RVA = "0xB6E570", Offset = "0xB6D370", VA = "0x10B6E570", Slot = "26")] get
      {
        return (JSONArray) null;
      }
    }

    [Token(Token = "0x170023B6")]
    public override JSONClass AsObject
    {
      [Token(Token = "0x600F857"), Address(RVA = "0xB6E7B0", Offset = "0xB6D5B0", VA = "0x10B6E7B0", Slot = "27")] get
      {
        return (JSONClass) null;
      }
    }
  }
}
