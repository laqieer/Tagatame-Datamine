// Decompiled with JetBrains decompiler
// Type: SRPG.Models.RuneDisassemblyResultModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200338C")]
  public class RuneDisassemblyResultModel
  {
    [Token(Token = "0x400F3F1")]
    [FieldOffset(Offset = "0x8")]
    private string _name;
    [Token(Token = "0x400F3F2")]
    [FieldOffset(Offset = "0xC")]
    private string _num;
    [Token(Token = "0x400F3F3")]
    [FieldOffset(Offset = "0x10")]
    private string _path;

    [Token(Token = "0x17001FEC")]
    public string IconPath
    {
      [Token(Token = "0x600E584"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FED")]
    public string Name
    {
      [Token(Token = "0x600E585"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001FEE")]
    public string Num
    {
      [Token(Token = "0x600E586"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600E587")]
    [Address(RVA = "0xAC21A0", Offset = "0xAC0FA0", VA = "0x10AC21A0")]
    public void Initialize(Json_Disassemble param)
    {
    }

    [Token(Token = "0x600E588")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public RuneDisassemblyResultModel()
    {
    }
  }
}
