// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactSelectListData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200148F")]
  public class ArtifactSelectListData
  {
    [Token(Token = "0x4004BD8")]
    [FieldOffset(Offset = "0x8")]
    public List<ArtifactSelectListItemData> items;

    [Token(Token = "0x60055DC")]
    [Address(RVA = "0x12B3E20", Offset = "0x12B2C20", VA = "0x112B3E20")]
    public void Deserialize(Json_ArtifactSelectResponse json)
    {
    }

    [Token(Token = "0x60055DD")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ArtifactSelectListData()
    {
    }
  }
}
