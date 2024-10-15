// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyStarMissionDailyItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B74")]
  [AddComponentMenu("UI/Trophy/TrophyStarMissionDailyItem")]
  public class TrophyStarMissionDailyItem : MonoBehaviour
  {
    [Token(Token = "0x400D4BF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text StarCount;
    [Token(Token = "0x400D4C0")]
    [FieldOffset(Offset = "0x10")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoUnachieved;
    [Token(Token = "0x400D4C1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_Button ButtonUnachieved;
    [Token(Token = "0x400D4C2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ImageArray IconUnachieved;
    [Token(Token = "0x400D4C3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoCanReceive;
    [Token(Token = "0x400D4C4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SRPG_Button ButtonCanReceive;
    [Token(Token = "0x400D4C5")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ImageArray IconCanReceive;
    [Token(Token = "0x400D4C6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [Space(5f)]
    private GameObject GoReceived;
    [Token(Token = "0x400D4C7")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private SRPG_Button ButtonReceived;
    [Token(Token = "0x400D4C8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray IconReceived;
    [Token(Token = "0x400D4C9")]
    [FieldOffset(Offset = "0x34")]
    private int mIndex;

    [Token(Token = "0x17001A68")]
    public int Index
    {
      [Token(Token = "0x600C712"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C713")]
    [Address(RVA = "0x904140", Offset = "0x902F40", VA = "0x10904140")]
    public void SetItem(int index, UnityAction action)
    {
    }

    [Token(Token = "0x600C714")]
    [Address(RVA = "0x903DA0", Offset = "0x902BA0", VA = "0x10903DA0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C715")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TrophyStarMissionDailyItem()
    {
    }
  }
}
