// Decompiled with JetBrains decompiler
// Type: SRPG.Json_GachaPickups
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F18")]
  [MessagePackObject(true)]
  public class Json_GachaPickups
  {
    [Token(Token = "0x4002EE4")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4002EE5")]
    [FieldOffset(Offset = "0xC")]
    public string itype;
    [Token(Token = "0x4002EE6")]
    [FieldOffset(Offset = "0x10")]
    public int num;
    [Token(Token = "0x4002EE7")]
    [FieldOffset(Offset = "0x14")]
    public int rank;

    [Token(Token = "0x6003F09")]
    [Address(RVA = "0x1182BE0", Offset = "0x11819E0", VA = "0x11182BE0")]
    public Json_GachaPickups()
    {
    }
  }
}
