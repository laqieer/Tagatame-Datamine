// Decompiled with JetBrains decompiler
// Type: SRPG.FlagManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E8C")]
  [MessagePackObject(true)]
  public struct FlagManager
  {
    [Token(Token = "0x4007ED2")]
    [FieldOffset(Offset = "0x0")]
    private int box;

    [Token(Token = "0x6007D31")]
    [Address(RVA = "0x3EC1F0", Offset = "0x3EAFF0", VA = "0x103EC1F0")]
    private bool Check(int id) => new bool();

    [Token(Token = "0x6007D32")]
    [Address(RVA = "0x3EC2B0", Offset = "0x3EB0B0", VA = "0x103EC2B0")]
    public void Set(int id, bool flag)
    {
    }

    [Token(Token = "0x6007D33")]
    [Address(RVA = "0x3EC300", Offset = "0x3EB100", VA = "0x103EC300")]
    private void True(int id)
    {
    }

    [Token(Token = "0x6007D34")]
    [Address(RVA = "0x3EC260", Offset = "0x3EB060", VA = "0x103EC260")]
    private void False(int id)
    {
    }

    [Token(Token = "0x6007D35")]
    [Address(RVA = "0x3EC290", Offset = "0x3EB090", VA = "0x103EC290")]
    public bool Is(int id) => new bool();
  }
}
