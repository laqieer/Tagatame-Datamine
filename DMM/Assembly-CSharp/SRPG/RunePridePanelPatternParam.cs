// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePanelPatternParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D04")]
  [MessagePackObject(true)]
  public class RunePridePanelPatternParam
  {
    [Token(Token = "0x40071C0")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x40071C1")]
    [FieldOffset(Offset = "0xC")]
    private string[] panel_ids;

    [Token(Token = "0x17000FAC")]
    public string Iname
    {
      [Token(Token = "0x600772C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FAD")]
    public string[] PanelIds
    {
      [Token(Token = "0x600772D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string[]) null;
      }
    }

    [Token(Token = "0x600772E")]
    [Address(RVA = "0x34E540", Offset = "0x34D340", VA = "0x1034E540")]
    public bool Deserialize(JSON_RunePridePanelPatternParam json) => new bool();

    [Token(Token = "0x600772F")]
    [Address(RVA = "0x39C910", Offset = "0x39B710", VA = "0x1039C910")]
    public static bool Deserialize(
      ref List<RunePridePanelPatternParam> paramList,
      JSON_RunePridePanelPatternParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007730")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePridePanelPatternParam()
    {
    }
  }
}
