// Decompiled with JetBrains decompiler
// Type: SRPG.GuildAttendanceRewardInfoListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002522")]
  [AddComponentMenu("UI/Guild/GuildAttendanceRewardInfoListItem")]
  public class GuildAttendanceRewardInfoListItem : MonoBehaviour
  {
    [Token(Token = "0x400A9C3")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [Header("報酬条件人数テキスト")]
    private Text ConditionsText;
    [Token(Token = "0x400A9C4")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("報酬アイコンの親")]
    private Transform ListItemRoot;
    [Token(Token = "0x400A9C5")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [Header("報酬アイコンのテンプレート")]
    private GameObject ListItemTemplate;

    [Token(Token = "0x600A340")]
    [Address(RVA = "0x651540", Offset = "0x650340", VA = "0x10651540")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A341")]
    [Address(RVA = "0x651DB0", Offset = "0x650BB0", VA = "0x10651DB0")]
    public void Setup(int member_count, GuildAttendRewardParam param)
    {
    }

    [Token(Token = "0x600A342")]
    [Address(RVA = "0x651590", Offset = "0x650390", VA = "0x10651590")]
    private void Refresh(int member_count, GuildAttendRewardParam param)
    {
    }

    [Token(Token = "0x600A343")]
    [Address(RVA = "0x651900", Offset = "0x650700", VA = "0x10651900")]
    private void SetRewardIcon(GuildAttendReward reward, RewardListItem listitem)
    {
    }

    [Token(Token = "0x600A344")]
    [Address(RVA = "0x6517B0", Offset = "0x6505B0", VA = "0x106517B0")]
    private void SetEmblem(GameObject obj, string iname)
    {
    }

    [Token(Token = "0x600A345")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildAttendanceRewardInfoListItem()
    {
    }
  }
}
