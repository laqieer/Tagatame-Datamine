// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePanelContentsParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D00")]
  [MessagePackObject(true)]
  public class RunePridePanelContentsParam
  {
    [Token(Token = "0x40071B4")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x40071B5")]
    [FieldOffset(Offset = "0xC")]
    private List<RunePridePanelSquareData> datas;

    [Token(Token = "0x17000FA6")]
    public string Iname
    {
      [Token(Token = "0x600771E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FA7")]
    public List<RunePridePanelSquareData> Datas
    {
      [Token(Token = "0x600771F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<RunePridePanelSquareData>) null;
      }
    }

    [Token(Token = "0x6007720")]
    [Address(RVA = "0x39C2C0", Offset = "0x39B0C0", VA = "0x1039C2C0")]
    public bool Deserialize(JSON_RunePridePanelContentsParam json) => new bool();

    [Token(Token = "0x6007721")]
    [Address(RVA = "0x39C4D0", Offset = "0x39B2D0", VA = "0x1039C4D0")]
    public static bool Deserialize(
      ref List<RunePridePanelContentsParam> paramList,
      JSON_RunePridePanelContentsParam[] jsons)
    {
      return new bool();
    }

    [Token(Token = "0x6007722")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RunePridePanelContentsParam()
    {
    }
  }
}
