// Decompiled with JetBrains decompiler
// Type: SRPG.JukeBoxSectionParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AFE")]
  [MessagePackObject(true)]
  public class JukeBoxSectionParam
  {
    [Token(Token = "0x40066CE")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x40066CF")]
    [FieldOffset(Offset = "0xC")]
    private string title;

    [Token(Token = "0x17000CE6")]
    public string Title
    {
      [Token(Token = "0x6006F67"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000CE7")]
    public string Iname
    {
      [Token(Token = "0x6006F68"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006F69")]
    [Address(RVA = "0x362350", Offset = "0x361150", VA = "0x10362350")]
    public bool Deserialize(JSON_JukeBoxSectionParam json) => new bool();

    [Token(Token = "0x6006F6A")]
    [Address(RVA = "0x36C1E0", Offset = "0x36AFE0", VA = "0x1036C1E0")]
    public static void Deserialize(
      ref List<JukeBoxSectionParam> ref_params,
      JSON_JukeBoxSectionParam[] json)
    {
    }

    [Token(Token = "0x6006F6B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JukeBoxSectionParam()
    {
    }
  }
}
