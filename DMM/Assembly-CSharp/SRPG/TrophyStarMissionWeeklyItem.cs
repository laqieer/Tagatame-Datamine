// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyStarMissionWeeklyItem
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
  [Token(Token = "0x2002B76")]
  [AddComponentMenu("UI/Trophy/TrophyStarMissionWeeklyItem")]
  public class TrophyStarMissionWeeklyItem : MonoBehaviour
  {
    [Token(Token = "0x400D4D1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text StarCount;
    [Token(Token = "0x400D4D2")]
    [FieldOffset(Offset = "0x10")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoUnachieved;
    [Token(Token = "0x400D4D3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_Button ButtonUnachieved;
    [Token(Token = "0x400D4D4")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoCanReceive;
    [Token(Token = "0x400D4D5")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button ButtonCanReceive;
    [Token(Token = "0x400D4D6")]
    [FieldOffset(Offset = "0x20")]
    [Space(5f)]
    [SerializeField]
    private GameObject GoReceived;
    [Token(Token = "0x400D4D7")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SRPG_Button ButtonReceived;
    [Token(Token = "0x400D4D8")]
    [FieldOffset(Offset = "0x28")]
    private int mIndex;

    [Token(Token = "0x17001A69")]
    public int Index
    {
      [Token(Token = "0x600C71A"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600C71B")]
    [Address(RVA = "0x904D00", Offset = "0x903B00", VA = "0x10904D00")]
    public void SetItem(int index, UnityAction action)
    {
    }

    [Token(Token = "0x600C71C")]
    [Address(RVA = "0x9049D0", Offset = "0x9037D0", VA = "0x109049D0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C71D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TrophyStarMissionWeeklyItem()
    {
    }
  }
}
