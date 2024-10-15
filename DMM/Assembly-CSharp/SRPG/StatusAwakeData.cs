// Decompiled with JetBrains decompiler
// Type: SRPG.StatusAwakeData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011D8")]
  [MessagePackObject(true)]
  public class StatusAwakeData
  {
    [Token(Token = "0x40040DA")]
    [FieldOffset(Offset = "0x8")]
    private string itemIname;
    [Token(Token = "0x40040DB")]
    [FieldOffset(Offset = "0xC")]
    private int num;

    [Token(Token = "0x17000851")]
    public string ItemIname
    {
      [Token(Token = "0x6004B83"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000852")]
    public int Num
    {
      [Token(Token = "0x6004B84"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6004B85")]
    [Address(RVA = "0x372170", Offset = "0x370F70", VA = "0x10372170")]
    public bool Deserialize(Json_StatusAwakeData json) => new bool();

    [Token(Token = "0x6004B86")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public StatusAwakeData()
    {
    }
  }
}
