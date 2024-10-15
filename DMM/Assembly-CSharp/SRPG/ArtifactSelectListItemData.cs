// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactSelectListItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200148E")]
  public class ArtifactSelectListItemData
  {
    [Token(Token = "0x4004BD4")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4004BD5")]
    [FieldOffset(Offset = "0xC")]
    public int id;
    [Token(Token = "0x4004BD6")]
    [FieldOffset(Offset = "0x10")]
    public int num;
    [Token(Token = "0x4004BD7")]
    [FieldOffset(Offset = "0x14")]
    public ArtifactParam param;

    [Token(Token = "0x60055DA")]
    [Address(RVA = "0x12B4030", Offset = "0x12B2E30", VA = "0x112B4030")]
    public void Deserialize(Json_ArtifactSelectItem json)
    {
    }

    [Token(Token = "0x60055DB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArtifactSelectListItemData()
    {
    }
  }
}
