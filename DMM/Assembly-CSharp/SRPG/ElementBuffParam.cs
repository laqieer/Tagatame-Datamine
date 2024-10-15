// Decompiled with JetBrains decompiler
// Type: SRPG.ElementBuffParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AC7")]
  [MessagePackObject(true)]
  public class ElementBuffParam
  {
    [Token(Token = "0x400633B")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x400633C")]
    [FieldOffset(Offset = "0xC")]
    private EElement mElement;
    [Token(Token = "0x400633D")]
    [FieldOffset(Offset = "0x10")]
    private int mElementPlus;
    [Token(Token = "0x400633E")]
    [FieldOffset(Offset = "0x14")]
    private int mHighElementAddRate;
    [Token(Token = "0x400633F")]
    [FieldOffset(Offset = "0x18")]
    private string mBuffIname;

    [Token(Token = "0x17000C74")]
    public EElement Element
    {
      [Token(Token = "0x6006E60"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x17000C75")]
    public int ElementPlus
    {
      [Token(Token = "0x6006E61"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C76")]
    public string BuffIname
    {
      [Token(Token = "0x6006E62"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C77")]
    public int AddRate
    {
      [Token(Token = "0x6006E63"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006E64")]
    [Address(RVA = "0x3609A0", Offset = "0x35F7A0", VA = "0x103609A0")]
    public bool Deserialize(JSON_ElementBuffParam json) => new bool();

    [Token(Token = "0x6006E65")]
    [Address(RVA = "0x3609F0", Offset = "0x35F7F0", VA = "0x103609F0")]
    public static bool Deserialize(
      ref List<ElementBuffParam> paramList,
      JSON_ElementBuffParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6006E66")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ElementBuffParam()
    {
    }
  }
}
