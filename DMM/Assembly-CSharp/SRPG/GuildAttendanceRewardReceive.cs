// Decompiled with JetBrains decompiler
// Type: SRPG.GuildAttendanceRewardReceive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002523")]
  [AddComponentMenu("UI/Guild/GuildAttendanceRewardReceive")]
  public class GuildAttendanceRewardReceive : MonoBehaviour
  {
    [Token(Token = "0x400A9C6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [Header("報酬アイコンのテンプレート")]
    private GameObject RewardTemplate;
    [Token(Token = "0x400A9C7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [Header("報酬アイコンのRoot")]
    private Transform RewardListRoot;
    [Token(Token = "0x400A9C8")]
    [FieldOffset(Offset = "0x14")]
    [Header("報酬文言を表示するテキスト")]
    [SerializeField]
    private Text RewardText;

    [Token(Token = "0x600A346")]
    [Address(RVA = "0x652120", Offset = "0x650F20", VA = "0x10652120")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A347")]
    [Address(RVA = "0x652BB0", Offset = "0x6519B0", VA = "0x10652BB0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A348")]
    [Address(RVA = "0x652770", Offset = "0x651570", VA = "0x10652770")]
    private void Setup()
    {
    }

    [Token(Token = "0x600A349")]
    [Address(RVA = "0x6522C0", Offset = "0x6510C0", VA = "0x106522C0")]
    private void SetRewardIcon(GuildAttendReward reward, RewardListItem listitem)
    {
    }

    [Token(Token = "0x600A34A")]
    [Address(RVA = "0x652170", Offset = "0x650F70", VA = "0x10652170")]
    private void SetEmblem(GameObject obj, string iname)
    {
    }

    [Token(Token = "0x600A34B")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GuildAttendanceRewardReceive()
    {
    }
  }
}
