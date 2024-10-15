// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRoleBonusRewardReceive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200252D")]
  [AddComponentMenu("UI/Guild/GuildRoleBonusRewardReceive")]
  public class GuildRoleBonusRewardReceive : MonoBehaviour
  {
    [Token(Token = "0x400AA35")]
    [FieldOffset(Offset = "0xC")]
    [Header("ポップアップタイトルテキスト")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400AA36")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("報酬文言")]
    private Text MainText;
    [Token(Token = "0x400AA37")]
    [FieldOffset(Offset = "0x14")]
    [Header("報酬リストアイテムの親")]
    [SerializeField]
    private Transform RewardListRoot;
    [Token(Token = "0x400AA38")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Header("報酬リストアイテムのテンプレート")]
    private GameObject RewardListItemTemplate;
    [Token(Token = "0x400AA39")]
    [FieldOffset(Offset = "0x1C")]
    [Header("報酬受け取りオブジェクト")]
    [SerializeField]
    private GameObject ReceivedStamp;
    [Token(Token = "0x400AA3A")]
    [FieldOffset(Offset = "0x20")]
    [Header("報酬受け取り済みオブジェクト")]
    [SerializeField]
    private GameObject AlreadyStamp;

    [Token(Token = "0x600A3B6")]
    [Address(RVA = "0x65DE40", Offset = "0x65CC40", VA = "0x1065DE40")]
    private void Start()
    {
    }

    [Token(Token = "0x600A3B7")]
    [Address(RVA = "0x65D7B0", Offset = "0x65C5B0", VA = "0x1065D7B0")]
    private void Setup()
    {
    }

    [Token(Token = "0x600A3B8")]
    [Address(RVA = "0x65D300", Offset = "0x65C100", VA = "0x1065D300")]
    private void SetRewardIcon(GuildRoleBonusReward reward, RewardListItem listitem)
    {
    }

    [Token(Token = "0x600A3B9")]
    [Address(RVA = "0x65D1B0", Offset = "0x65BFB0", VA = "0x1065D1B0")]
    private void SetEmblem(GameObject obj, string iname)
    {
    }

    [Token(Token = "0x600A3BA")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildRoleBonusRewardReceive()
    {
    }

    [Token(Token = "0x200252E")]
    public enum eReceiveStatus
    {
      [Token(Token = "0x400AA3C")] NOT_RECEIVED = 1,
      [Token(Token = "0x400AA3D")] ALREADY_RECEIVED = 2,
    }
  }
}
