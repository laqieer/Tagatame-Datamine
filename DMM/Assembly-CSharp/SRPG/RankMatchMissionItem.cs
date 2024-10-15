// Decompiled with JetBrains decompiler
// Type: SRPG.RankMatchMissionItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200291D")]
  public class RankMatchMissionItem : ListItemEvents
  {
    [Token(Token = "0x400C5F9")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject Completed;
    [Token(Token = "0x400C5FA")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button GetRewardButton;
    [Token(Token = "0x400C5FB")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject Count;
    [Token(Token = "0x400C5FC")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject RewardUnit;
    [Token(Token = "0x400C5FD")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject RewardItem;
    [Token(Token = "0x400C5FE")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject RewardCard;
    [Token(Token = "0x400C5FF")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject RewardArtifact;
    [Token(Token = "0x400C600")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject RewardAward;
    [Token(Token = "0x400C601")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject RewardGold;
    [Token(Token = "0x400C602")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject RewardCoin;
    [Token(Token = "0x400C603")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Transform RewardList;
    [Token(Token = "0x400C604")]
    [FieldOffset(Offset = "0x64")]
    private RankMatchMissionWindow mWindow;

    [Token(Token = "0x600BA10")]
    [Address(RVA = "0x810EB0", Offset = "0x80FCB0", VA = "0x10810EB0")]
    public void Initialize(RankMatchMissionWindow window)
    {
    }

    [Token(Token = "0x600BA11")]
    [Address(RVA = "0x811320", Offset = "0x810120", VA = "0x10811320")]
    public void MissionComplate()
    {
    }

    [Token(Token = "0x600BA12")]
    [Address(RVA = "0x43AD40", Offset = "0x439B40", VA = "0x1043AD40")]
    public RankMatchMissionItem()
    {
    }
  }
}
