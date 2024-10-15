// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardIconNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002217")]
  public class ConceptCardIconNode : ContentNode
  {
    [Token(Token = "0x40096A8")]
    [FieldOffset(Offset = "0x30")]
    private readonly string CONCEPT_CARD_EQUIP_REMOVE_TEXT;
    [Token(Token = "0x40096A9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public ConceptCardIcon Icon;
    [Token(Token = "0x40096AA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    public GameObject EmptyObject;
    [Token(Token = "0x40096AB")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    public LText EmptyText;
    [Token(Token = "0x40096AC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    public GameObject DecreaseEffect;
    [Token(Token = "0x40096AD")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    public Text DecreaseEffectText;
    [Token(Token = "0x40096AE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mGvGUsedItem;
    [Token(Token = "0x40096AF")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mGvGUsedText;

    [Token(Token = "0x60090A4")]
    [Address(RVA = "0x53AC50", Offset = "0x539A50", VA = "0x1053AC50")]
    public void Setup(ConceptCardData cc_data)
    {
    }

    [Token(Token = "0x60090A5")]
    [Address(RVA = "0x53A8E0", Offset = "0x5396E0", VA = "0x1053A8E0")]
    public void SetNotSellFlag(bool not_sale)
    {
    }

    [Token(Token = "0x60090A6")]
    [Address(RVA = "0x53A090", Offset = "0x538E90", VA = "0x1053A090")]
    public void Empty(bool is_enmpty)
    {
    }

    [Token(Token = "0x60090A7")]
    [Address(RVA = "0x53A140", Offset = "0x538F40", VA = "0x1053A140")]
    public void Enable(bool enable)
    {
    }

    [Token(Token = "0x60090A8")]
    [Address(RVA = "0x53A540", Offset = "0x539340", VA = "0x1053A540")]
    public void Select(bool select)
    {
    }

    [Token(Token = "0x60090A9")]
    [Address(RVA = "0x53A390", Offset = "0x539190", VA = "0x1053A390")]
    public void Recommend(bool is_recommend)
    {
    }

    [Token(Token = "0x60090AA")]
    [Address(RVA = "0x53A810", Offset = "0x539610", VA = "0x1053A810")]
    public void SetDecreaseEffectActive(bool isEnableDecreaseEffect, int decreaseEffectRate)
    {
    }

    [Token(Token = "0x60090AB")]
    [Address(RVA = "0x53AB30", Offset = "0x539930", VA = "0x1053AB30")]
    public void SetUsedActive(bool isEnable)
    {
    }

    [Token(Token = "0x60090AC")]
    [Address(RVA = "0x53A980", Offset = "0x539780", VA = "0x1053A980")]
    public void SetOrganization(bool isValue)
    {
    }

    [Token(Token = "0x60090AD")]
    [Address(RVA = "0x53A660", Offset = "0x539460", VA = "0x1053A660")]
    public void SetBeforeUsed(bool isValue)
    {
    }

    [Token(Token = "0x60090AE")]
    [Address(RVA = "0x53A2C0", Offset = "0x5390C0", VA = "0x1053A2C0")]
    private void LeagueMatchUsed(bool isEnable)
    {
    }

    [Token(Token = "0x60090AF")]
    [Address(RVA = "0x53AD00", Offset = "0x539B00", VA = "0x1053AD00")]
    public ConceptCardIconNode()
    {
    }
  }
}
