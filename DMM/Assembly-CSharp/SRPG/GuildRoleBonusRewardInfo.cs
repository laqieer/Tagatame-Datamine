// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRoleBonusRewardInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200252B")]
  [AddComponentMenu("UI/Guild/GuildRoleBonusRewardInfo")]
  public class GuildRoleBonusRewardInfo : MonoBehaviour
  {
    [Token(Token = "0x400AA2F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [Header("報酬リストアイテムの親")]
    private Transform RewardListRoot;
    [Token(Token = "0x400AA30")]
    [FieldOffset(Offset = "0x10")]
    [Header("報酬リストアイテムのテンプレート")]
    [SerializeField]
    private GameObject RewardListItemTemplate;
    [Token(Token = "0x400AA31")]
    [FieldOffset(Offset = "0x14")]
    [Header("現在の施設本部Lvテキスト")]
    [SerializeField]
    private Text GuildCurrentFacilityLvText;

    [Token(Token = "0x600A3AD")]
    [Address(RVA = "0x65CD30", Offset = "0x65BB30", VA = "0x1065CD30")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A3AE")]
    [Address(RVA = "0x65D090", Offset = "0x65BE90", VA = "0x1065D090")]
    private void Start()
    {
    }

    [Token(Token = "0x600A3AF")]
    [Address(RVA = "0x65CD80", Offset = "0x65BB80", VA = "0x1065CD80")]
    private void Refresh(GuildRoleBonusParam param)
    {
    }

    [Token(Token = "0x600A3B0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildRoleBonusRewardInfo()
    {
    }
  }
}
