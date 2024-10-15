// Decompiled with JetBrains decompiler
// Type: SRPG.MultiInvitationReceiveWindow
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
  [Token(Token = "0x2002767")]
  public class MultiInvitationReceiveWindow : FlowWindowBase
  {
    [Token(Token = "0x400BA50")]
    [FieldOffset(Offset = "0x30")]
    private MultiInvitationReceiveWindow.SerializeParam m_Param;
    [Token(Token = "0x400BA51")]
    [FieldOffset(Offset = "0x34")]
    private MultiInvitationReceiveWindow.Tab m_Tab;
    [Token(Token = "0x400BA52")]
    [FieldOffset(Offset = "0x38")]
    private bool m_Destroy;
    [Token(Token = "0x400BA53")]
    [FieldOffset(Offset = "0x3C")]
    private MultiInvitationReceiveWindow.ActiveContent.ItemSource m_ActiveSource;
    [Token(Token = "0x400BA54")]
    [FieldOffset(Offset = "0x40")]
    private ContentController m_ActiveController;
    [Token(Token = "0x400BA55")]
    [FieldOffset(Offset = "0x44")]
    private MultiInvitationReceiveWindow.LogContent.ItemSource m_LogSource;
    [Token(Token = "0x400BA56")]
    [FieldOffset(Offset = "0x48")]
    private ContentController m_LogController;
    [Token(Token = "0x400BA57")]
    [FieldOffset(Offset = "0x4C")]
    private SerializeValueBehaviour m_ValueList;
    [Token(Token = "0x400BA58")]
    [FieldOffset(Offset = "0x50")]
    private Toggle m_ActiveToggle;
    [Token(Token = "0x400BA59")]
    [FieldOffset(Offset = "0x54")]
    private Toggle m_LogToggle;
    [Token(Token = "0x400BA5A")]
    [FieldOffset(Offset = "0x58")]
    private MultiInvitationReceiveWindow.ActiveData m_ActiveData;
    [Token(Token = "0x400BA5B")]
    [FieldOffset(Offset = "0x5C")]
    private MultiInvitationReceiveWindow.LogData m_LogData;
    [Token(Token = "0x400BA5C")]
    [FieldOffset(Offset = "0x0")]
    private static MultiInvitationReceiveWindow m_Instance;

    [Token(Token = "0x17001864")]
    public override string name
    {
      [Token(Token = "0x600B0CF"), Address(RVA = "0x747E90", Offset = "0x746C90", VA = "0x10747E90", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001865")]
    public static MultiInvitationReceiveWindow instance
    {
      [Token(Token = "0x600B0D0"), Address(RVA = "0x747E60", Offset = "0x746C60", VA = "0x10747E60")] get
      {
        return (MultiInvitationReceiveWindow) null;
      }
    }

    [Token(Token = "0x600B0D1")]
    [Address(RVA = "0x747A70", Offset = "0x746870", VA = "0x10747A70")]
    public static void SetBadge(bool value)
    {
    }

    [Token(Token = "0x600B0D2")]
    [Address(RVA = "0x7470C0", Offset = "0x745EC0", VA = "0x107470C0", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x600B0D3")]
    [Address(RVA = "0x747A10", Offset = "0x746810", VA = "0x10747A10", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x600B0D4")]
    [Address(RVA = "0x747D40", Offset = "0x746B40", VA = "0x10747D40", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x600B0D5")]
    [Address(RVA = "0x747B40", Offset = "0x746940", VA = "0x10747B40")]
    private bool SetTab(MultiInvitationReceiveWindow.Tab tab) => new bool();

    [Token(Token = "0x600B0D6")]
    [Address(RVA = "0x746C30", Offset = "0x745A30", VA = "0x10746C30")]
    public void InitializeActiveList()
    {
    }

    [Token(Token = "0x600B0D7")]
    [Address(RVA = "0x7478F0", Offset = "0x7466F0", VA = "0x107478F0")]
    public void ReleaseActiveList()
    {
    }

    [Token(Token = "0x600B0D8")]
    [Address(RVA = "0x746E70", Offset = "0x745C70", VA = "0x10746E70")]
    public void InitializeLogList()
    {
    }

    [Token(Token = "0x600B0D9")]
    [Address(RVA = "0x747980", Offset = "0x746780", VA = "0x10747980")]
    public void ReleaseLogList()
    {
    }

    [Token(Token = "0x600B0DA")]
    [Address(RVA = "0x746BB0", Offset = "0x7459B0", VA = "0x10746BB0")]
    private MultiInvitationReceiveWindow.ActiveData.RoomData GetActiveRoomData(int roomId)
    {
      return (MultiInvitationReceiveWindow.ActiveData.RoomData) null;
    }

    [Token(Token = "0x600B0DB")]
    [Address(RVA = "0x746C10", Offset = "0x745A10", VA = "0x10746C10")]
    public int GetLogPage() => new int();

    [Token(Token = "0x600B0DC")]
    [Address(RVA = "0x7474D0", Offset = "0x7462D0", VA = "0x107474D0", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x600B0DD")]
    [Address(RVA = "0x746AC0", Offset = "0x7458C0", VA = "0x10746AC0")]
    public bool DeserializeActiveList(
      FlowNode_ReqMultiInvitation.Api_RoomInvitation.Json json)
    {
      return new bool();
    }

    [Token(Token = "0x600B0DE")]
    [Address(RVA = "0x746B30", Offset = "0x745930", VA = "0x10746B30")]
    public bool DeserializeLogList(
      int page,
      FlowNode_ReqMultiInvitationHistory.Api_MultiInvitationHistory.Json json)
    {
      return new bool();
    }

    [Token(Token = "0x600B0DF")]
    [Address(RVA = "0x4A5B50", Offset = "0x4A4950", VA = "0x104A5B50")]
    public MultiInvitationReceiveWindow()
    {
    }

    [Token(Token = "0x2002768")]
    public enum Tab
    {
      [Token(Token = "0x400BA5E")] NONE,
      [Token(Token = "0x400BA5F")] ACTIVE,
      [Token(Token = "0x400BA60")] LOG,
    }

    [Token(Token = "0x2002769")]
    public enum MultiType
    {
      [Token(Token = "0x400BA62")] NONE,
      [Token(Token = "0x400BA63")] NORMAL,
      [Token(Token = "0x400BA64")] TOWER,
    }

    [Token(Token = "0x200276A")]
    public static class ActiveContent
    {
      [Token(Token = "0x400BA65")]
      [FieldOffset(Offset = "0x0")]
      public static MultiInvitationReceiveWindow.ActiveContent.ItemAccessor clickItem;

      [Token(Token = "0x200276B")]
      public class ItemAccessor
      {
        [Token(Token = "0x400BA66")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x400BA67")]
        [FieldOffset(Offset = "0xC")]
        private MultiInvitationReceiveWindow.ActiveData.RoomData m_Param;
        [Token(Token = "0x400BA68")]
        [FieldOffset(Offset = "0x10")]
        private DataSource m_DataSource;
        [Token(Token = "0x400BA69")]
        [FieldOffset(Offset = "0x14")]
        private SerializeValueBehaviour m_Value;

        [Token(Token = "0x17001866")]
        public ContentNode node
        {
          [Token(Token = "0x600B0E0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x17001867")]
        public MultiInvitationReceiveWindow.ActiveData.RoomData param
        {
          [Token(Token = "0x600B0E1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (MultiInvitationReceiveWindow.ActiveData.RoomData) null;
          }
        }

        [Token(Token = "0x17001868")]
        public bool isValid
        {
          [Token(Token = "0x600B0E2"), Address(RVA = "0x7458F0", Offset = "0x7446F0", VA = "0x107458F0")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600B0E3")]
        [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
        public void Setup(
          MultiInvitationReceiveWindow.ActiveData.RoomData param)
        {
        }

        [Token(Token = "0x600B0E4")]
        [Address(RVA = "0x744D90", Offset = "0x743B90", VA = "0x10744D90")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x600B0E5")]
        [Address(RVA = "0x7455E0", Offset = "0x7443E0", VA = "0x107455E0")]
        public void Clear()
        {
        }

        [Token(Token = "0x600B0E6")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x600B0E7")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x200276C")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x400BA6A")]
        [FieldOffset(Offset = "0x10")]
        private List<MultiInvitationReceiveWindow.ActiveContent.ItemSource.ItemParam> m_Params;

        [Token(Token = "0x600B0E8")]
        [Address(RVA = "0x745F80", Offset = "0x744D80", VA = "0x10745F80", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x600B0E9")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x600B0EA")]
        [Address(RVA = "0x745E10", Offset = "0x744C10", VA = "0x10745E10")]
        public void Add(
          MultiInvitationReceiveWindow.ActiveContent.ItemSource.ItemParam param)
        {
        }

        [Token(Token = "0x600B0EB")]
        [Address(RVA = "0x745FC0", Offset = "0x744DC0", VA = "0x10745FC0")]
        public void Setup()
        {
        }

        [Token(Token = "0x600B0EC")]
        [Address(RVA = "0x7466F0", Offset = "0x7454F0", VA = "0x107466F0")]
        public ItemSource()
        {
        }

        [Token(Token = "0x200276D")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400BA6B")]
          [FieldOffset(Offset = "0x10")]
          private MultiInvitationReceiveWindow.ActiveContent.ItemAccessor m_Accessor;

          [Token(Token = "0x600B0ED")]
          [Address(RVA = "0x745A00", Offset = "0x744800", VA = "0x10745A00", Slot = "6")]
          public override bool IsValid() => new bool();

          [Token(Token = "0x17001869")]
          public MultiInvitationReceiveWindow.ActiveContent.ItemAccessor accerror
          {
            [Token(Token = "0x600B0EE"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (MultiInvitationReceiveWindow.ActiveContent.ItemAccessor) null;
            }
          }

          [Token(Token = "0x1700186A")]
          public MultiInvitationReceiveWindow.ActiveData.RoomData param
          {
            [Token(Token = "0x600B0EF"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (MultiInvitationReceiveWindow.ActiveData.RoomData) null;
            }
          }

          [Token(Token = "0x600B0F0")]
          [Address(RVA = "0x745C90", Offset = "0x744A90", VA = "0x10745C90")]
          public ItemParam(
            MultiInvitationReceiveWindow.ActiveData.RoomData param)
          {
          }

          [Token(Token = "0x600B0F1")]
          [Address(RVA = "0x745C00", Offset = "0x744A00", VA = "0x10745C00", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x600B0F2")]
          [Address(RVA = "0x745AC0", Offset = "0x7448C0", VA = "0x10745AC0", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x600B0F3")]
          [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x200276F")]
    public static class LogContent
    {
      [Token(Token = "0x400BA6E")]
      [FieldOffset(Offset = "0x0")]
      public static MultiInvitationReceiveWindow.LogContent.ItemAccessor clickItem;

      [Token(Token = "0x2002770")]
      public class ItemAccessor
      {
        [Token(Token = "0x400BA6F")]
        [FieldOffset(Offset = "0x8")]
        private ContentNode m_Node;
        [Token(Token = "0x400BA70")]
        [FieldOffset(Offset = "0xC")]
        private MultiInvitationReceiveWindow.LogData.RoomData m_Param;
        [Token(Token = "0x400BA71")]
        [FieldOffset(Offset = "0x10")]
        private DataSource m_DataSource;
        [Token(Token = "0x400BA72")]
        [FieldOffset(Offset = "0x14")]
        private SerializeValueBehaviour m_Value;

        [Token(Token = "0x1700186B")]
        public ContentNode node
        {
          [Token(Token = "0x600B0F7"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x1700186C")]
        public MultiInvitationReceiveWindow.LogData.RoomData param
        {
          [Token(Token = "0x600B0F8"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
          {
            return (MultiInvitationReceiveWindow.LogData.RoomData) null;
          }
        }

        [Token(Token = "0x1700186D")]
        public bool isValid
        {
          [Token(Token = "0x600B0F9"), Address(RVA = "0x745890", Offset = "0x744690", VA = "0x10745890")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600B0FA")]
        [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
        public void Setup(
          MultiInvitationReceiveWindow.LogData.RoomData param)
        {
        }

        [Token(Token = "0x600B0FB")]
        [Address(RVA = "0x745010", Offset = "0x743E10", VA = "0x10745010")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x600B0FC")]
        [Address(RVA = "0x745660", Offset = "0x744460", VA = "0x10745660")]
        public void Clear()
        {
        }

        [Token(Token = "0x600B0FD")]
        [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x600B0FE")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }
      }

      [Token(Token = "0x2002771")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x400BA73")]
        [FieldOffset(Offset = "0x10")]
        private List<MultiInvitationReceiveWindow.LogContent.ItemSource.ItemParam> m_Params;

        [Token(Token = "0x600B0FF")]
        [Address(RVA = "0x745F60", Offset = "0x744D60", VA = "0x10745F60", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x600B100")]
        [Address(RVA = "0x4ADBB0", Offset = "0x4AC9B0", VA = "0x104ADBB0", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x600B101")]
        [Address(RVA = "0x745E80", Offset = "0x744C80", VA = "0x10745E80")]
        public void Add(
          MultiInvitationReceiveWindow.LogContent.ItemSource.ItemParam param)
        {
        }

        [Token(Token = "0x600B102")]
        [Address(RVA = "0x7461F0", Offset = "0x744FF0", VA = "0x107461F0")]
        public void Setup()
        {
        }

        [Token(Token = "0x600B103")]
        [Address(RVA = "0x746680", Offset = "0x745480", VA = "0x10746680")]
        public ItemSource()
        {
        }

        [Token(Token = "0x2002772")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400BA74")]
          [FieldOffset(Offset = "0x10")]
          private MultiInvitationReceiveWindow.LogContent.ItemAccessor m_Accessor;

          [Token(Token = "0x600B104")]
          [Address(RVA = "0x7459A0", Offset = "0x7447A0", VA = "0x107459A0", Slot = "6")]
          public override bool IsValid() => new bool();

          [Token(Token = "0x1700186E")]
          public MultiInvitationReceiveWindow.LogContent.ItemAccessor accerror
          {
            [Token(Token = "0x600B105"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (MultiInvitationReceiveWindow.LogContent.ItemAccessor) null;
            }
          }

          [Token(Token = "0x1700186F")]
          public MultiInvitationReceiveWindow.LogData.RoomData param
          {
            [Token(Token = "0x600B106"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
            {
              return (MultiInvitationReceiveWindow.LogData.RoomData) null;
            }
          }

          [Token(Token = "0x600B107")]
          [Address(RVA = "0x745D90", Offset = "0x744B90", VA = "0x10745D90")]
          public ItemParam(
            MultiInvitationReceiveWindow.LogData.RoomData param)
          {
          }

          [Token(Token = "0x600B108")]
          [Address(RVA = "0x745C60", Offset = "0x744A60", VA = "0x10745C60", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x600B109")]
          [Address(RVA = "0x745A40", Offset = "0x744840", VA = "0x10745A40", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x600B10A")]
          [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x2002774")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x400BA77")]
      [FieldOffset(Offset = "0xC")]
      public GameObject tabActive;
      [Token(Token = "0x400BA78")]
      [FieldOffset(Offset = "0x10")]
      public GameObject tabLog;
      [Token(Token = "0x400BA79")]
      [FieldOffset(Offset = "0x14")]
      public GameObject activeList;
      [Token(Token = "0x400BA7A")]
      [FieldOffset(Offset = "0x18")]
      public GameObject logList;

      [Token(Token = "0x17001870")]
      public override System.Type type
      {
        [Token(Token = "0x600B10E"), Address(RVA = "0x74B760", Offset = "0x74A560", VA = "0x1074B760", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x600B10F")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }

    [Token(Token = "0x2002775")]
    public class ActiveData
    {
      [Token(Token = "0x400BA7B")]
      [FieldOffset(Offset = "0x8")]
      public MultiInvitationReceiveWindow.ActiveData.RoomData[] rooms;

      [Token(Token = "0x600B110")]
      [Address(RVA = "0x7446E0", Offset = "0x7434E0", VA = "0x107446E0")]
      public bool Decerialize(
        FlowNode_ReqMultiInvitation.Api_RoomInvitation.Json json)
      {
        return new bool();
      }

      [Token(Token = "0x600B111")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ActiveData()
      {
      }

      [Token(Token = "0x2002776")]
      public class OwnerData
      {
        [Token(Token = "0x400BA7C")]
        [FieldOffset(Offset = "0x8")]
        public FriendData friend;
        [Token(Token = "0x400BA7D")]
        [FieldOffset(Offset = "0xC")]
        public UnitData unit;

        [Token(Token = "0x17001871")]
        public bool isValid
        {
          [Token(Token = "0x600B112"), Address(RVA = "0x39EF50", Offset = "0x39DD50", VA = "0x1039EF50")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x17001872")]
        public string fuid
        {
          [Token(Token = "0x600B113"), Address(RVA = "0x749500", Offset = "0x748300", VA = "0x10749500")] get
          {
            return (string) null;
          }
        }

        [Token(Token = "0x600B114")]
        [Address(RVA = "0x749360", Offset = "0x748160", VA = "0x10749360")]
        public OwnerData(
          FlowNode_ReqMultiInvitation.Api_RoomInvitation.JsonRoomOwner json)
        {
        }
      }

      [Token(Token = "0x2002778")]
      public class QuestData
      {
        [Token(Token = "0x400BA7F")]
        [FieldOffset(Offset = "0x8")]
        public QuestParam param;

        [Token(Token = "0x17001873")]
        public bool isValid
        {
          [Token(Token = "0x600B117"), Address(RVA = "0x39EF50", Offset = "0x39DD50", VA = "0x1039EF50")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600B118")]
        [Address(RVA = "0x74B670", Offset = "0x74A470", VA = "0x1074B670")]
        public QuestData(
          FlowNode_ReqMultiInvitation.Api_RoomInvitation.JsonRoomQuest json)
        {
        }
      }

      [Token(Token = "0x2002779")]
      public class RoomData
      {
        [Token(Token = "0x400BA80")]
        [FieldOffset(Offset = "0x8")]
        public int roomid;
        [Token(Token = "0x400BA81")]
        [FieldOffset(Offset = "0xC")]
        public string comment;
        [Token(Token = "0x400BA82")]
        [FieldOffset(Offset = "0x10")]
        public int num;
        [Token(Token = "0x400BA83")]
        [FieldOffset(Offset = "0x14")]
        public MultiInvitationReceiveWindow.MultiType multiType;
        [Token(Token = "0x400BA84")]
        [FieldOffset(Offset = "0x18")]
        public MultiInvitationReceiveWindow.ActiveData.OwnerData owner;
        [Token(Token = "0x400BA85")]
        [FieldOffset(Offset = "0x1C")]
        public MultiInvitationReceiveWindow.ActiveData.QuestData quest;
        [Token(Token = "0x400BA86")]
        [FieldOffset(Offset = "0x20")]
        public bool locked;

        [Token(Token = "0x17001874")]
        public bool isValid
        {
          [Token(Token = "0x600B119"), Address(RVA = "0x74B6E0", Offset = "0x74A4E0", VA = "0x1074B6E0")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600B11A")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public RoomData()
        {
        }
      }
    }

    [Token(Token = "0x200277A")]
    public class LogData
    {
      [Token(Token = "0x400BA87")]
      [FieldOffset(Offset = "0x8")]
      public int page;
      [Token(Token = "0x400BA88")]
      [FieldOffset(Offset = "0xC")]
      public MultiInvitationReceiveWindow.LogData.RoomData[] rooms;

      [Token(Token = "0x600B11B")]
      [Address(RVA = "0x746760", Offset = "0x745560", VA = "0x10746760")]
      public bool Decerialize(
        int _page,
        FlowNode_ReqMultiInvitationHistory.Api_MultiInvitationHistory.Json json)
      {
        return new bool();
      }

      [Token(Token = "0x600B11C")]
      [Address(RVA = "0x746AA0", Offset = "0x7458A0", VA = "0x10746AA0")]
      public LogData()
      {
      }

      [Token(Token = "0x200277B")]
      public class OwnerData
      {
        [Token(Token = "0x400BA89")]
        [FieldOffset(Offset = "0x8")]
        public string uid;
        [Token(Token = "0x400BA8A")]
        [FieldOffset(Offset = "0xC")]
        public string fuid;
        [Token(Token = "0x400BA8B")]
        [FieldOffset(Offset = "0x10")]
        public string name;
        [Token(Token = "0x400BA8C")]
        [FieldOffset(Offset = "0x14")]
        public int lv;
        [Token(Token = "0x400BA8D")]
        [FieldOffset(Offset = "0x18")]
        public UnitData unit;

        [Token(Token = "0x17001875")]
        public bool isValid
        {
          [Token(Token = "0x600B11D"), Address(RVA = "0x749520", Offset = "0x748320", VA = "0x10749520")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600B11E")]
        [Address(RVA = "0x749290", Offset = "0x748090", VA = "0x10749290")]
        public OwnerData(
          FlowNode_ReqMultiInvitationHistory.Api_MultiInvitationHistory.JsonPlayer json)
        {
        }
      }

      [Token(Token = "0x200277C")]
      public class QuestData
      {
        [Token(Token = "0x400BA8E")]
        [FieldOffset(Offset = "0x8")]
        public QuestParam param;

        [Token(Token = "0x17001876")]
        public bool isValid
        {
          [Token(Token = "0x600B11F"), Address(RVA = "0x39EF50", Offset = "0x39DD50", VA = "0x1039EF50")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600B120")]
        [Address(RVA = "0x74B600", Offset = "0x74A400", VA = "0x1074B600")]
        public QuestData(string iname)
        {
        }
      }

      [Token(Token = "0x200277D")]
      public class RoomData
      {
        [Token(Token = "0x400BA8F")]
        [FieldOffset(Offset = "0x8")]
        public int id;
        [Token(Token = "0x400BA90")]
        [FieldOffset(Offset = "0xC")]
        public int roomid;
        [Token(Token = "0x400BA91")]
        [FieldOffset(Offset = "0x10")]
        public MultiInvitationReceiveWindow.MultiType multiType;
        [Token(Token = "0x400BA92")]
        [FieldOffset(Offset = "0x18")]
        public long created_at;
        [Token(Token = "0x400BA93")]
        [FieldOffset(Offset = "0x20")]
        public MultiInvitationReceiveWindow.LogData.OwnerData owner;
        [Token(Token = "0x400BA94")]
        [FieldOffset(Offset = "0x24")]
        public MultiInvitationReceiveWindow.LogData.QuestData quest;

        [Token(Token = "0x17001877")]
        public bool isValid
        {
          [Token(Token = "0x600B121"), Address(RVA = "0x74B710", Offset = "0x74A510", VA = "0x1074B710")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600B122")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public RoomData()
        {
        }
      }
    }
  }
}
