// Decompiled with JetBrains decompiler
// Type: SRPG.GuildEnhanceMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F90")]
  public class GuildEnhanceMaterial
  {
    [Token(Token = "0x40036C6")]
    [FieldOffset(Offset = "0x8")]
    public string facility_iname;
    [Token(Token = "0x40036C7")]
    [FieldOffset(Offset = "0xC")]
    public List<EnhanceMaterial> materials;
    [Token(Token = "0x40036C8")]
    [FieldOffset(Offset = "0x10")]
    public long gold;

    [Token(Token = "0x60040A7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GuildEnhanceMaterial()
    {
    }
  }
}
