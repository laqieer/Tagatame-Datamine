// Decompiled with JetBrains decompiler
// Type: SRPG.ElementPieceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AC9")]
  [MessagePackObject(true)]
  public class ElementPieceParam
  {
    [Token(Token = "0x4006345")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006346")]
    [FieldOffset(Offset = "0xC")]
    private EElement mElement;
    [Token(Token = "0x4006347")]
    [FieldOffset(Offset = "0x10")]
    private int mElementPlus;
    [Token(Token = "0x4006348")]
    [FieldOffset(Offset = "0x14")]
    private string mCommonPieceIname;
    [Token(Token = "0x4006349")]
    [FieldOffset(Offset = "0x18")]
    private string mElementPieceIname;

    [Token(Token = "0x17000C78")]
    public EElement Element
    {
      [Token(Token = "0x6006E68"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new EElement();
      }
    }

    [Token(Token = "0x17000C79")]
    public int ElementPlus
    {
      [Token(Token = "0x6006E69"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000C7A")]
    public string ElementPiece
    {
      [Token(Token = "0x6006E6A"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000C7B")]
    public string CommonPiece
    {
      [Token(Token = "0x6006E6B"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006E6C")]
    [Address(RVA = "0x360D20", Offset = "0x35FB20", VA = "0x10360D20")]
    public bool Deserialize(JSON_ElementPieceParam json) => new bool();

    [Token(Token = "0x6006E6D")]
    [Address(RVA = "0x360B90", Offset = "0x35F990", VA = "0x10360B90")]
    public static bool Deserialize(
      ref List<ElementPieceParam> paramList,
      JSON_ElementPieceParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6006E6E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ElementPieceParam()
    {
    }
  }
}
