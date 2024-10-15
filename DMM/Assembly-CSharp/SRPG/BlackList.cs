// Decompiled with JetBrains decompiler
// Type: SRPG.BlackList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200208D")]
  [FlowNode.Pin(2, "Prev", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(10, "Detail Request", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "BlackList Request", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("UI/BlackList")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Next", FlowNode.PinTypes.Input, 1)]
  public class BlackList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008C52")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform ItemRoot;
    [Token(Token = "0x4008C53")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject ItemTemplate;
    [Token(Token = "0x4008C54")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject ItemEmpty;
    [Token(Token = "0x4008C55")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button Prev;
    [Token(Token = "0x4008C56")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button Next;
    [Token(Token = "0x4008C57")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text Pager;
    [Token(Token = "0x4008C58")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ListExtras ScrollView;
    [Token(Token = "0x4008C59")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text ChatMaintenanceMsg;
    [Token(Token = "0x4008C5A")]
    [FieldOffset(Offset = "0x2C")]
    public int LimitView;
    [Token(Token = "0x4008C5B")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> mItems;
    [Token(Token = "0x4008C5C")]
    [FieldOffset(Offset = "0x34")]
    private ChatBlackList mBlackList;
    [Token(Token = "0x4008C5D")]
    [FieldOffset(Offset = "0x38")]
    private int mListTotal;
    [Token(Token = "0x4008C5E")]
    [FieldOffset(Offset = "0x3C")]
    private int mCurrentPage;

    [Token(Token = "0x1700132A")]
    public ChatBlackList BList
    {
      [Token(Token = "0x6008782"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (ChatBlackList) null;
      }
      [Token(Token = "0x6008783"), Address(RVA = "0x34C030", Offset = "0x34AE30", VA = "0x1034C030")] set
      {
      }
    }

    [Token(Token = "0x1700132B")]
    public int ListTotal
    {
      [Token(Token = "0x6008784"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return new int();
      }
      [Token(Token = "0x6008785"), Address(RVA = "0x374A30", Offset = "0x373830", VA = "0x10374A30")] set
      {
      }
    }

    [Token(Token = "0x6008786")]
    [Address(RVA = "0x48EAB0", Offset = "0x48D8B0", VA = "0x1048EAB0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008787")]
    [Address(RVA = "0x48EB40", Offset = "0x48D940", VA = "0x1048EB40")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008788")]
    [Address(RVA = "0x48F4F0", Offset = "0x48E2F0", VA = "0x1048F4F0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008789")]
    [Address(RVA = "0x48EBF0", Offset = "0x48D9F0", VA = "0x1048EBF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600878A")]
    [Address(RVA = "0x48F450", Offset = "0x48E250", VA = "0x1048F450")]
    private void ResetBlackListItems()
    {
    }

    [Token(Token = "0x600878B")]
    [Address(RVA = "0x48ED70", Offset = "0x48DB70", VA = "0x1048ED70")]
    public void RefreshMaintenanceMessage(string message)
    {
    }

    [Token(Token = "0x600878C")]
    [Address(RVA = "0x48EE00", Offset = "0x48DC00", VA = "0x1048EE00")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600878D")]
    [Address(RVA = "0x48EC60", Offset = "0x48DA60", VA = "0x1048EC60")]
    private void OnSelectItems(string uid)
    {
    }

    [Token(Token = "0x600878E")]
    [Address(RVA = "0x48ED00", Offset = "0x48DB00", VA = "0x1048ED00")]
    private void OnSelectPage(int offset)
    {
    }

    [Token(Token = "0x600878F")]
    [Address(RVA = "0x48F540", Offset = "0x48E340", VA = "0x1048F540")]
    public BlackList()
    {
    }
  }
}
