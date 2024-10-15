// Decompiled with JetBrains decompiler
// Type: SRPG.BoxGachaLineupListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020F0")]
  public class BoxGachaLineupListWindow : FlowWindowBase
  {
    [Token(Token = "0x4008E6C")]
    [FieldOffset(Offset = "0x30")]
    private BoxGachaLineupListWindow.SerializeParam m_Param;
    [Token(Token = "0x4008E6D")]
    [FieldOffset(Offset = "0x34")]
    private bool m_Destroy;
    [Token(Token = "0x4008E6E")]
    [FieldOffset(Offset = "0x38")]
    private BoxGachaLineupListWindow.LineupContent.ItemSource m_LineupSource;
    [Token(Token = "0x4008E6F")]
    [FieldOffset(Offset = "0x3C")]
    private ContentController m_LineupController;
    [Token(Token = "0x4008E70")]
    [FieldOffset(Offset = "0x40")]
    private BoxGachaLineupListWindow.LineupData m_LineupData;
    [Token(Token = "0x4008E71")]
    [FieldOffset(Offset = "0x0")]
    private static BoxGachaLineupListWindow m_Instance;

    [Token(Token = "0x17001368")]
    public int step
    {
      [Token(Token = "0x6008992"), Address(RVA = "0x4A5B90", Offset = "0x4A4990", VA = "0x104A5B90")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001369")]
    public static BoxGachaLineupListWindow Instance
    {
      [Token(Token = "0x6008993"), Address(RVA = "0x4A5B60", Offset = "0x4A4960", VA = "0x104A5B60")] get
      {
        return (BoxGachaLineupListWindow) null;
      }
    }

    [Token(Token = "0x6008994")]
    [Address(RVA = "0x4A5860", Offset = "0x4A4660", VA = "0x104A5860", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x6008995")]
    [Address(RVA = "0x4A5AC0", Offset = "0x4A48C0", VA = "0x104A5AC0", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x6008996")]
    [Address(RVA = "0x4A5B10", Offset = "0x4A4910", VA = "0x104A5B10", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x6008997")]
    [Address(RVA = "0x4A55D0", Offset = "0x4A43D0", VA = "0x104A55D0")]
    public void InitalizeLineupList()
    {
    }

    [Token(Token = "0x6008998")]
    [Address(RVA = "0x4A5A30", Offset = "0x4A4830", VA = "0x104A5A30")]
    public void ReleaseLineupList()
    {
    }

    [Token(Token = "0x6008999")]
    [Address(RVA = "0x4A5550", Offset = "0x4A4350", VA = "0x104A5550")]
    public bool DeserializeLineupList(JSON_BoxGachaSteps json, bool is_lineup = false)
    {
      return new bool();
    }

    [Token(Token = "0x600899A")]
    [Address(RVA = "0x4A5A00", Offset = "0x4A4800", VA = "0x104A5A00", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x600899B")]
    [Address(RVA = "0x4A5B50", Offset = "0x4A4950", VA = "0x104A5B50")]
    public BoxGachaLineupListWindow()
    {
    }

    [Token(Token = "0x20020F1")]
    public static class LineupContent
    {
      [Token(Token = "0x4008E72")]
      [FieldOffset(Offset = "0x0")]
      public static BoxGachaLineupListWindow.LineupContent.ItemAccessor clickItem;

      [Token(Token = "0x20020F2")]
      public class ItemAccessor
      {
        [Token(Token = "0x4008E73")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x4008E74")]
        [FieldOffset(Offset = "0xC")]
        private BoxGachaLineupListWindow.LineupData.BoxItemData m_Param;
        [Token(Token = "0x4008E75")]
        [FieldOffset(Offset = "0x10")]
        private DataSource m_DataSource;
        [Token(Token = "0x4008E76")]
        [FieldOffset(Offset = "0x14")]
        private GameObject m_Pickup;
        [Token(Token = "0x4008E77")]
        [FieldOffset(Offset = "0x18")]
        private GameObject m_NormalTop;
        [Token(Token = "0x4008E78")]
        [FieldOffset(Offset = "0x1C")]
        private GameObject m_NormalDefault;
        [Token(Token = "0x4008E79")]
        [FieldOffset(Offset = "0x20")]
        private GameObject m_FeatureBadge;
        [Token(Token = "0x4008E7A")]
        [FieldOffset(Offset = "0x24")]
        private Text m_Name;
        [Token(Token = "0x4008E7B")]
        [FieldOffset(Offset = "0x28")]
        private Text m_Remain;
        [Token(Token = "0x4008E7C")]
        [FieldOffset(Offset = "0x2C")]
        private Text m_Num;
        [Token(Token = "0x4008E7D")]
        [FieldOffset(Offset = "0x30")]
        private GameObject m_Icon;
        [Token(Token = "0x4008E7E")]
        [FieldOffset(Offset = "0x34")]
        private Text m_RemainAllFeture;
        [Token(Token = "0x4008E7F")]
        [FieldOffset(Offset = "0x38")]
        private Text m_RemainAllNormal;

        [Token(Token = "0x1700136A")]
        public ContentNode node
        {
          [Token(Token = "0x600899C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x1700136B")]
        public BoxGachaLineupListWindow.LineupData.BoxItemData param
        {
          [Token(Token = "0x600899D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (BoxGachaLineupListWindow.LineupData.BoxItemData) null;
          }
        }

        [Token(Token = "0x600899E")]
        [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
        public void Setup(
          BoxGachaLineupListWindow.LineupData.BoxItemData param)
        {
        }

        [Token(Token = "0x600899F")]
        [Address(RVA = "0x4ACEF0", Offset = "0x4ABCF0", VA = "0x104ACEF0")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x60089A0")]
        [Address(RVA = "0x4AD990", Offset = "0x4AC790", VA = "0x104AD990")]
        public void Clear()
        {
        }

        [Token(Token = "0x60089A1")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x60089A2")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x20020F3")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x4008E80")]
        [FieldOffset(Offset = "0x10")]
        private List<BoxGachaLineupListWindow.LineupContent.ItemSource.ItemParam> m_Params;

        [Token(Token = "0x60089A3")]
        [Address(RVA = "0x4ADB90", Offset = "0x4AC990", VA = "0x104ADB90", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x60089A4")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x60089A5")]
        [Address(RVA = "0x4ADB40", Offset = "0x4AC940", VA = "0x104ADB40")]
        public void Add(
          BoxGachaLineupListWindow.LineupContent.ItemSource.ItemParam param)
        {
        }

        [Token(Token = "0x60089A6")]
        [Address(RVA = "0x4ADBC0", Offset = "0x4AC9C0", VA = "0x104ADBC0")]
        public void Setup()
        {
        }

        [Token(Token = "0x60089A7")]
        [Address(RVA = "0x4ADD60", Offset = "0x4ACB60", VA = "0x104ADD60")]
        public ItemSource()
        {
        }

        [Token(Token = "0x20020F4")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x4008E81")]
          [FieldOffset(Offset = "0x10")]
          private BoxGachaLineupListWindow.LineupContent.ItemAccessor m_Accessor;

          [Token(Token = "0x1700136C")]
          public BoxGachaLineupListWindow.LineupContent.ItemAccessor accessor
          {
            [Token(Token = "0x60089A8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (BoxGachaLineupListWindow.LineupContent.ItemAccessor) null;
            }
          }

          [Token(Token = "0x1700136D")]
          public BoxGachaLineupListWindow.LineupData.BoxItemData param
          {
            [Token(Token = "0x60089A9"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (BoxGachaLineupListWindow.LineupData.BoxItemData) null;
            }
          }

          [Token(Token = "0x60089AA")]
          [Address(RVA = "0x4ADAC0", Offset = "0x4AC8C0", VA = "0x104ADAC0")]
          public ItemParam(
            BoxGachaLineupListWindow.LineupData.BoxItemData param)
          {
          }

          [Token(Token = "0x60089AB")]
          [Address(RVA = "0x4ADA90", Offset = "0x4AC890", VA = "0x104ADA90", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x60089AC")]
          [Address(RVA = "0x4ADA10", Offset = "0x4AC810", VA = "0x104ADA10", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x60089AD")]
          [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x20020F6")]
    public class LineupData
    {
      [Token(Token = "0x4008E84")]
      [FieldOffset(Offset = "0x8")]
      private int m_Step;
      [Token(Token = "0x4008E85")]
      [FieldOffset(Offset = "0xC")]
      private int m_TotalNum;
      [Token(Token = "0x4008E86")]
      [FieldOffset(Offset = "0x10")]
      private BoxGachaLineupListWindow.LineupData.BoxItemData[] m_BoxItems;

      [Token(Token = "0x1700136E")]
      public int step
      {
        [Token(Token = "0x60089B1"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x1700136F")]
      public int total
      {
        [Token(Token = "0x60089B2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x17001370")]
      public BoxGachaLineupListWindow.LineupData.BoxItemData[] box_items
      {
        [Token(Token = "0x60089B3"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return (BoxGachaLineupListWindow.LineupData.BoxItemData[]) null;
        }
      }

      [Token(Token = "0x60089B4")]
      [Address(RVA = "0x4ADDD0", Offset = "0x4ACBD0", VA = "0x104ADDD0")]
      public bool Deserialize(JSON_BoxGachaSteps json, bool is_lineup = false) => new bool();

      [Token(Token = "0x60089B5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LineupData()
      {
      }

      [Token(Token = "0x20020F7")]
      public class BoxItemData
      {
        [Token(Token = "0x4008E87")]
        [FieldOffset(Offset = "0x8")]
        private bool m_IsFeatureItem;
        [Token(Token = "0x4008E88")]
        [FieldOffset(Offset = "0xC")]
        private string m_Itype;
        [Token(Token = "0x4008E89")]
        [FieldOffset(Offset = "0x10")]
        private string m_Iname;
        [Token(Token = "0x4008E8A")]
        [FieldOffset(Offset = "0x14")]
        private int m_Num;
        [Token(Token = "0x4008E8B")]
        [FieldOffset(Offset = "0x18")]
        private int m_TotalNum;
        [Token(Token = "0x4008E8C")]
        [FieldOffset(Offset = "0x1C")]
        private int m_RemainNum;
        [Token(Token = "0x4008E8D")]
        [FieldOffset(Offset = "0x20")]
        private int m_Coin;
        [Token(Token = "0x4008E8E")]
        [FieldOffset(Offset = "0x24")]
        private int m_Gold;
        [Token(Token = "0x4008E8F")]
        [FieldOffset(Offset = "0x28")]
        private string m_BoxSetIname;
        [Token(Token = "0x4008E90")]
        [FieldOffset(Offset = "0x2C")]
        private string m_BoxSetName;
        [Token(Token = "0x4008E91")]
        [FieldOffset(Offset = "0x30")]
        private bool m_IsFirst;
        [Token(Token = "0x4008E92")]
        [FieldOffset(Offset = "0x34")]
        private string m_Name;
        [Token(Token = "0x4008E93")]
        [FieldOffset(Offset = "0x38")]
        private bool m_IsLineup;
        [Token(Token = "0x4008E94")]
        [FieldOffset(Offset = "0x3C")]
        private int m_TotalNumFeature;
        [Token(Token = "0x4008E95")]
        [FieldOffset(Offset = "0x40")]
        private int m_TotalNumNormal;
        [Token(Token = "0x4008E96")]
        [FieldOffset(Offset = "0x44")]
        private int m_RemainNumFeature;
        [Token(Token = "0x4008E97")]
        [FieldOffset(Offset = "0x48")]
        private int m_RemainNumNormal;
        [Token(Token = "0x4008E98")]
        [FieldOffset(Offset = "0x4C")]
        private GenesisRewardDataParam m_Reward;

        [Token(Token = "0x17001371")]
        public bool isFeatureItem
        {
          [Token(Token = "0x60089B6"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x17001372")]
        public string itype
        {
          [Token(Token = "0x60089B7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x17001373")]
        public string iname
        {
          [Token(Token = "0x60089B8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x17001374")]
        public int num
        {
          [Token(Token = "0x60089B9"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17001375")]
        public int total_num
        {
          [Token(Token = "0x60089BA"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17001376")]
        public int remain_num
        {
          [Token(Token = "0x60089BB"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17001377")]
        public int coin
        {
          [Token(Token = "0x60089BC"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17001378")]
        public int gold
        {
          [Token(Token = "0x60089BD"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17001379")]
        public string box_set_iname
        {
          [Token(Token = "0x60089BE"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x1700137A")]
        public string box_set_name
        {
          [Token(Token = "0x60089BF"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x1700137B")]
        public bool isFirst
        {
          [Token(Token = "0x60089C0"), Address(RVA = "0x380080", Offset = "0x37EE80", VA = "0x10380080")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x1700137C")]
        public GenesisRewardDataParam reward
        {
          [Token(Token = "0x60089C1"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
          {
            return (GenesisRewardDataParam) null;
          }
        }

        [Token(Token = "0x1700137D")]
        public string name
        {
          [Token(Token = "0x60089C2"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x1700137E")]
        public bool isLineup
        {
          [Token(Token = "0x60089C3"), Address(RVA = "0x2836F0", Offset = "0x2824F0", VA = "0x102836F0")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x1700137F")]
        public int total_num_feature
        {
          [Token(Token = "0x60089C4"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17001380")]
        public int total_num_normal
        {
          [Token(Token = "0x60089C5"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17001381")]
        public int remain_num_feature
        {
          [Token(Token = "0x60089C6"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17001382")]
        public int remain_num_normal
        {
          [Token(Token = "0x60089C7"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x60089C8")]
        [Address(RVA = "0x4AA230", Offset = "0x4A9030", VA = "0x104AA230")]
        public BoxItemData(JSON_BoxGachaItems json, bool is_first = false, bool is_lineup = false)
        {
        }

        [Token(Token = "0x60089C9")]
        [Address(RVA = "0x4A9DC0", Offset = "0x4A8BC0", VA = "0x104A9DC0")]
        private void Init(JSON_BoxGachaItems json, bool is_first = false, bool is_lineup = false)
        {
        }

        [Token(Token = "0x60089CA")]
        [Address(RVA = "0x4AA200", Offset = "0x4A9000", VA = "0x104AA200")]
        public void SetTotalNum(int total, int remain, bool is_feature = false)
        {
        }
      }
    }

    [Token(Token = "0x20020F8")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x4008E99")]
      [FieldOffset(Offset = "0xC")]
      public GameObject lineupList;

      [Token(Token = "0x17001383")]
      public override System.Type type
      {
        [Token(Token = "0x60089CB"), Address(RVA = "0x4B4F50", Offset = "0x4B3D50", VA = "0x104B4F50", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x60089CC")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }
  }
}
