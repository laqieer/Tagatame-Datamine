// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardTrustRewardItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A7C")]
  public class ConceptCardTrustRewardItemParam
  {
    [Token(Token = "0x40061F7")]
    [FieldOffset(Offset = "0x8")]
    public eRewardType reward_type;
    [Token(Token = "0x40061F8")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x40061F9")]
    [FieldOffset(Offset = "0x10")]
    public int reward_num;

    [Token(Token = "0x6006CD3")]
    [Address(RVA = "0x3569E0", Offset = "0x3557E0", VA = "0x103569E0")]
    public bool Deserialize(JSON_ConceptCardTrustRewardItemParam json) => new bool();

    [Token(Token = "0x6006CD4")]
    [Address(RVA = "0x356D90", Offset = "0x355B90", VA = "0x10356D90")]
    public string GetItemName() => (string) null;

    [Token(Token = "0x6006CD5")]
    [Address(RVA = "0x356C30", Offset = "0x355A30", VA = "0x10356C30")]
    public string GetIconPath() => (string) null;

    [Token(Token = "0x6006CD6")]
    [Address(RVA = "0x356AC0", Offset = "0x3558C0", VA = "0x10356AC0")]
    public Sprite GetFrameSprite() => (Sprite) null;

    [Token(Token = "0x6006CD7")]
    [Address(RVA = "0x356A20", Offset = "0x355820", VA = "0x10356A20")]
    public Sprite GetArtifactSprite(ArtifactParam param) => (Sprite) null;

    [Token(Token = "0x6006CD8")]
    [Address(RVA = "0x356A70", Offset = "0x355870", VA = "0x10356A70")]
    public Sprite GetConceptCardSprite(ConceptCardParam param) => (Sprite) null;

    [Token(Token = "0x6006CD9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardTrustRewardItemParam()
    {
    }
  }
}
