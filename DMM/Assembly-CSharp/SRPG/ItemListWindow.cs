// Decompiled with JetBrains decompiler
// Type: SRPG.ItemListWindow
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
  [Token(Token = "0x200265E")]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/リスト/アイテム")]
  [FlowNode.Pin(100, "詳細表示", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  public class ItemListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B36A")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ItemTemplate;
    [Token(Token = "0x400B36B")]
    [FieldOffset(Offset = "0x10")]
    public Toggle ToggleShowUsed;
    [Token(Token = "0x400B36C")]
    [FieldOffset(Offset = "0x14")]
    public Toggle ToggleShowEquip;
    [Token(Token = "0x400B36D")]
    [FieldOffset(Offset = "0x18")]
    public Toggle ToggleShowMaterial;
    [Token(Token = "0x400B36E")]
    [FieldOffset(Offset = "0x1C")]
    public Toggle ToggleShowEvolMaterial;
    [Token(Token = "0x400B36F")]
    [FieldOffset(Offset = "0x20")]
    public Toggle ToggleShowUnitPiece;
    [Token(Token = "0x400B370")]
    [FieldOffset(Offset = "0x24")]
    public Toggle ToggleShowArtifactPiece;
    [Token(Token = "0x400B371")]
    [FieldOffset(Offset = "0x28")]
    public Toggle ToggleShowTicket;
    [Token(Token = "0x400B372")]
    [FieldOffset(Offset = "0x2C")]
    public Toggle ToggleShowOther;
    [Token(Token = "0x400B373")]
    [FieldOffset(Offset = "0x30")]
    private ItemData SelectItem;
    [Token(Token = "0x400B374")]
    [FieldOffset(Offset = "0x34")]
    private ItemListWindow.ItemSource m_ItemSource;
    [Token(Token = "0x400B375")]
    [FieldOffset(Offset = "0x38")]
    private ContentController m_ContenController;

    [Token(Token = "0x600AB59")]
    [Address(RVA = "0x6E75A0", Offset = "0x6E63A0", VA = "0x106E75A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AB5A")]
    [Address(RVA = "0x6E7DF0", Offset = "0x6E6BF0", VA = "0x106E7DF0")]
    private void Start()
    {
    }

    [Token(Token = "0x600AB5B")]
    [Address(RVA = "0x6E7A40", Offset = "0x6E6840", VA = "0x106E7A40")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AB5C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600AB5D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AB5E")]
    [Address(RVA = "0x6E7D00", Offset = "0x6E6B00", VA = "0x106E7D00")]
    public void SetupNodeEvent(ContentNode node)
    {
    }

    [Token(Token = "0x600AB5F")]
    [Address(RVA = "0x6E7CD0", Offset = "0x6E6AD0", VA = "0x106E7CD0")]
    private void OnShowUsed(bool isActive)
    {
    }

    [Token(Token = "0x600AB60")]
    [Address(RVA = "0x6E7BB0", Offset = "0x6E69B0", VA = "0x106E7BB0")]
    private void OnShowEquip(bool isActive)
    {
    }

    [Token(Token = "0x600AB61")]
    [Address(RVA = "0x6E7C10", Offset = "0x6E6A10", VA = "0x106E7C10")]
    private void OnShowMaterial(bool isActive)
    {
    }

    [Token(Token = "0x600AB62")]
    [Address(RVA = "0x6E7BE0", Offset = "0x6E69E0", VA = "0x106E7BE0")]
    private void OnShowEvolMaterial(bool isActive)
    {
    }

    [Token(Token = "0x600AB63")]
    [Address(RVA = "0x6E7CA0", Offset = "0x6E6AA0", VA = "0x106E7CA0")]
    private void OnShowUnitPiece(bool isActive)
    {
    }

    [Token(Token = "0x600AB64")]
    [Address(RVA = "0x6E7B80", Offset = "0x6E6980", VA = "0x106E7B80")]
    private void OnShowArtifactPiece(bool isActive)
    {
    }

    [Token(Token = "0x600AB65")]
    [Address(RVA = "0x6E7C70", Offset = "0x6E6A70", VA = "0x106E7C70")]
    private void OnShowTicket(bool isActive)
    {
    }

    [Token(Token = "0x600AB66")]
    [Address(RVA = "0x6E7C40", Offset = "0x6E6A40", VA = "0x106E7C40")]
    private void OnShowOther(bool isActive)
    {
    }

    [Token(Token = "0x600AB67")]
    [Address(RVA = "0x6E7AE0", Offset = "0x6E68E0", VA = "0x106E7AE0")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600AB68")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ItemListWindow()
    {
    }

    [Token(Token = "0x200265F")]
    private class ItemNode : ContentNode
    {
      [Token(Token = "0x400B376")]
      [FieldOffset(Offset = "0x30")]
      private DataSource m_DataSource;
      [Token(Token = "0x400B377")]
      [FieldOffset(Offset = "0x34")]
      private GameParameter[] m_GameParameters;

      [Token(Token = "0x170017F8")]
      public DataSource dataSource
      {
        [Token(Token = "0x600AB69"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
        {
          return (DataSource) null;
        }
      }

      [Token(Token = "0x600AB6A")]
      [Address(RVA = "0x6E8D30", Offset = "0x6E7B30", VA = "0x106E8D30", Slot = "4")]
      public override void Initialize(ContentController controller)
      {
      }

      [Token(Token = "0x600AB6B")]
      [Address(RVA = "0x596DD0", Offset = "0x595BD0", VA = "0x10596DD0", Slot = "5")]
      public override void Release()
      {
      }

      [Token(Token = "0x600AB6C")]
      [Address(RVA = "0x6E8C90", Offset = "0x6E7A90", VA = "0x106E8C90")]
      public void ForceUpdate()
      {
      }

      [Token(Token = "0x600AB6D")]
      [Address(RVA = "0x6E8F10", Offset = "0x6E7D10", VA = "0x106E8F10")]
      private void OnSelect(GameObject go)
      {
      }

      [Token(Token = "0x600AB6E")]
      [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
      public ItemNode()
      {
      }
    }

    [Token(Token = "0x2002660")]
    public class ItemSource : ContentSource
    {
      [Token(Token = "0x400B378")]
      [FieldOffset(Offset = "0x10")]
      private EItemTabType m_ItemType;
      [Token(Token = "0x400B379")]
      [FieldOffset(Offset = "0x14")]
      private List<ItemListWindow.ItemSource.ItemParam> m_Params;

      [Token(Token = "0x600AB6F")]
      [Address(RVA = "0x6E92E0", Offset = "0x6E80E0", VA = "0x106E92E0", Slot = "4")]
      public override void Initialize(ContentController controller)
      {
      }

      [Token(Token = "0x600AB70")]
      [Address(RVA = "0x6E93B0", Offset = "0x6E81B0", VA = "0x106E93B0", Slot = "5")]
      public override void Release()
      {
      }

      [Token(Token = "0x600AB71")]
      [Address(RVA = "0x6E9310", Offset = "0x6E8110", VA = "0x106E9310", Slot = "8")]
      public override ContentNode Instantiate(ContentNode res) => (ContentNode) null;

      [Token(Token = "0x600AB72")]
      [Address(RVA = "0x6E9270", Offset = "0x6E8070", VA = "0x106E9270")]
      public void Add(ItemListWindow.ItemSource.ItemParam param)
      {
      }

      [Token(Token = "0x600AB73")]
      [Address(RVA = "0x6E93D0", Offset = "0x6E81D0", VA = "0x106E93D0")]
      public void SelectType(EItemTabType itemType)
      {
      }

      [Token(Token = "0x600AB74")]
      [Address(RVA = "0x6E9590", Offset = "0x6E8390", VA = "0x106E9590")]
      public ItemSource()
      {
      }

      [Token(Token = "0x2002661")]
      public class ItemParam : ContentSource.Param
      {
        [Token(Token = "0x400B37A")]
        [FieldOffset(Offset = "0x10")]
        private ItemData m_Item;

        [Token(Token = "0x600AB75")]
        [Address(RVA = "0x596DE0", Offset = "0x595BE0", VA = "0x10596DE0", Slot = "6")]
        public override bool IsValid() => new bool();

        [Token(Token = "0x170017F9")]
        public ItemData data
        {
          [Token(Token = "0x600AB76"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
          {
            return (ItemData) null;
          }
        }

        [Token(Token = "0x170017FA")]
        public EItemType itemType
        {
          [Token(Token = "0x600AB77"), Address(RVA = "0x6E9170", Offset = "0x6E7F70", VA = "0x106E9170")] get
          {
            return new EItemType();
          }
        }

        [Token(Token = "0x600AB78")]
        [Address(RVA = "0x596EA0", Offset = "0x595CA0", VA = "0x10596EA0")]
        public ItemParam(ItemData item)
        {
        }

        [Token(Token = "0x600AB79")]
        [Address(RVA = "0x6E8FC0", Offset = "0x6E7DC0", VA = "0x106E8FC0", Slot = "11")]
        public override void OnSetup(ContentNode node)
        {
        }
      }
    }
  }
}
