// Decompiled with JetBrains decompiler
// Type: SRPG.GuildAttendanceRewardInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002521")]
  [AddComponentMenu("UI/Guild/GuildAttendanceRewardInfo")]
  public class GuildAttendanceRewardInfo : MonoBehaviour
  {
    [Token(Token = "0x400A9C1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [Header("報酬リストアイテムの親")]
    private Transform RewardListRoot;
    [Token(Token = "0x400A9C2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("報酬リストアイテムのテンプレート")]
    private GameObject RewardListItemTemplate;

    [Token(Token = "0x600A33C")]
    [Address(RVA = "0x651DC0", Offset = "0x650BC0", VA = "0x10651DC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A33D")]
    [Address(RVA = "0x652040", Offset = "0x650E40", VA = "0x10652040")]
    private void Start()
    {
    }

    [Token(Token = "0x600A33E")]
    [Address(RVA = "0x651E10", Offset = "0x650C10", VA = "0x10651E10")]
    private void Refresh(GuildAttendParam param)
    {
    }

    [Token(Token = "0x600A33F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildAttendanceRewardInfo()
    {
    }
  }
}
