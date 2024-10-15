// Decompiled with JetBrains decompiler
// Type: SRPG.RuneIconNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029AB")]
  public class RuneIconNode : ContentNode
  {
    [Token(Token = "0x400C9E4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    public RuneIcon Icon;
    [Token(Token = "0x400C9E5")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    public GameObject GvGUsed;
    [Token(Token = "0x400C9E6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mGvGUsedText;
    [Token(Token = "0x400C9E7")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mLeagueMatchUsed;

    [Token(Token = "0x600BD31")]
    [Address(RVA = "0x84C100", Offset = "0x84AF00", VA = "0x1084C100")]
    public void Setup(BindRuneData rune_data)
    {
    }

    [Token(Token = "0x600BD32")]
    [Address(RVA = "0x84BFE0", Offset = "0x84ADE0", VA = "0x1084BFE0")]
    public void SetUsedActive(bool isEnable)
    {
    }

    [Token(Token = "0x600BD33")]
    [Address(RVA = "0x84BF10", Offset = "0x84AD10", VA = "0x1084BF10")]
    public void SetOrganization(bool isValue)
    {
    }

    [Token(Token = "0x600BD34")]
    [Address(RVA = "0x84BE40", Offset = "0x84AC40", VA = "0x1084BE40")]
    public void SetBeforeUsed(bool isValue)
    {
    }

    [Token(Token = "0x600BD35")]
    [Address(RVA = "0x84BD60", Offset = "0x84AB60", VA = "0x1084BD60")]
    private void LeagueMatchUsed(bool isEnable)
    {
    }

    [Token(Token = "0x600BD36")]
    [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
    public RuneIconNode()
    {
    }
  }
}
