// Decompiled with JetBrains decompiler
// Type: SRPG.RuneListWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029AF")]
  [AddComponentMenu("UI/リスト/ルーン")]
  [FlowNode.Pin(1, "Start", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "詳細表示", FlowNode.PinTypes.Output, 100)]
  public class RuneListWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CA22")]
    [FieldOffset(Offset = "0xC")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400CA24")]
    [FieldOffset(Offset = "0x14")]
    private RuneListWindow.RuneSource m_RuneSource;
    [Token(Token = "0x400CA25")]
    [FieldOffset(Offset = "0x18")]
    private ContentController m_ContenController;

    [Token(Token = "0x14000011")]
    private event RuneListWindow.OnSelectedEvent mOnSelectedEvent
    {
      [Token(Token = "0x600BD5C"), Address(RVA = "0x8506E0", Offset = "0x84F4E0", VA = "0x108506E0")] add
      {
      }
      [Token(Token = "0x600BD5D"), Address(RVA = "0x850760", Offset = "0x84F560", VA = "0x10850760")] remove
      {
      }
    }

    [Token(Token = "0x600BD5E")]
    [Address(RVA = "0x84FF00", Offset = "0x84ED00", VA = "0x1084FF00")]
    private void Awake()
    {
    }

    [Token(Token = "0x600BD5F")]
    [Address(RVA = "0x84FF60", Offset = "0x84ED60", VA = "0x1084FF60")]
    public void Initialize(RuneManager manager, List<BindRuneData> runes)
    {
    }

    [Token(Token = "0x600BD60")]
    [Address(RVA = "0x850210", Offset = "0x84F010", VA = "0x10850210")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BD61")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600BD62")]
    [Address(RVA = "0x8504E0", Offset = "0x84F2E0", VA = "0x108504E0")]
    public void UpdateGameParameterAll()
    {
    }

    [Token(Token = "0x600BD63")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BD64")]
    [Address(RVA = "0x8503F0", Offset = "0x84F1F0", VA = "0x108503F0")]
    public void SetupNodeEvent(ContentNode node)
    {
    }

    [Token(Token = "0x600BD65")]
    [Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")]
    public void SetSelectedCallBack(RuneListWindow.OnSelectedEvent selected)
    {
    }

    [Token(Token = "0x600BD66")]
    [Address(RVA = "0x8502B0", Offset = "0x84F0B0", VA = "0x108502B0")]
    private void OnSelect(GameObject go)
    {
    }

    [Token(Token = "0x600BD67")]
    [Address(RVA = "0x850310", Offset = "0x84F110", VA = "0x10850310")]
    public void SelectTypeCurrent(bool is_force = false)
    {
    }

    [Token(Token = "0x600BD68")]
    [Address(RVA = "0x850360", Offset = "0x84F160", VA = "0x10850360")]
    public void SelectType(int seteff_type, bool is_force = false)
    {
    }

    [Token(Token = "0x600BD69")]
    [Address(RVA = "0x850390", Offset = "0x84F190", VA = "0x10850390")]
    public void SelectType(RuneSlotIndex slot_index, bool is_force = false)
    {
    }

    [Token(Token = "0x600BD6A")]
    [Address(RVA = "0x850340", Offset = "0x84F140", VA = "0x10850340")]
    public void SelectType(int seteff_type, RuneSlotIndex slot_index, bool is_force = false)
    {
    }

    [Token(Token = "0x600BD6B")]
    [Address(RVA = "0x8503C0", Offset = "0x84F1C0", VA = "0x108503C0")]
    public void SetLockDisable(bool is_lock_disable)
    {
    }

    [Token(Token = "0x600BD6C")]
    [Address(RVA = "0x850500", Offset = "0x84F300", VA = "0x10850500")]
    public RuneListWindow()
    {
    }

    [Token(Token = "0x20029B0")]
    public delegate void OnSelectedEvent(BindRuneData rune);

    [Token(Token = "0x20029B1")]
    private class RuneNode : ContentNode
    {
      [Token(Token = "0x400CA26")]
      [FieldOffset(Offset = "0x30")]
      private DataSource m_DataSource;
      [Token(Token = "0x400CA27")]
      [FieldOffset(Offset = "0x34")]
      private GameParameter[] m_GameParameters;
      [Token(Token = "0x400CA28")]
      [FieldOffset(Offset = "0x38")]
      private RuneDrawListIcon m_RuneDrawListIcon;

      [Token(Token = "0x17001994")]
      public DataSource dataSource
      {
        [Token(Token = "0x600BD71"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
        {
          return (DataSource) null;
        }
      }

      [Token(Token = "0x600BD72")]
      [Address(RVA = "0x853FC0", Offset = "0x852DC0", VA = "0x10853FC0", Slot = "4")]
      public override void Initialize(ContentController controller)
      {
      }

      [Token(Token = "0x600BD73")]
      [Address(RVA = "0x596DD0", Offset = "0x595BD0", VA = "0x10596DD0", Slot = "5")]
      public override void Release()
      {
      }

      [Token(Token = "0x600BD74")]
      [Address(RVA = "0x8541E0", Offset = "0x852FE0", VA = "0x108541E0")]
      public void Refresh()
      {
      }

      [Token(Token = "0x600BD75")]
      [Address(RVA = "0x4180F0", Offset = "0x416EF0", VA = "0x104180F0")]
      public RuneNode()
      {
      }
    }

    [Token(Token = "0x20029B2")]
    public class RuneSource : ContentSource
    {
      [Token(Token = "0x400CA29")]
      [FieldOffset(Offset = "0x10")]
      private int m_RuneSetEffType;
      [Token(Token = "0x400CA2A")]
      [FieldOffset(Offset = "0x14")]
      private RuneSlotIndex m_RuneSlotIndex;
      [Token(Token = "0x400CA2B")]
      [FieldOffset(Offset = "0x18")]
      private List<RuneListWindow.RuneSource.ContentParam> m_Params;
      [Token(Token = "0x400CA2C")]
      [FieldOffset(Offset = "0x1C")]
      private bool m_IsLockDisable;

      [Token(Token = "0x600BD76")]
      [Address(RVA = "0x854360", Offset = "0x853160", VA = "0x10854360", Slot = "4")]
      public override void Initialize(ContentController controller)
      {
      }

      [Token(Token = "0x600BD77")]
      [Address(RVA = "0x854440", Offset = "0x853240", VA = "0x10854440", Slot = "5")]
      public override void Release()
      {
      }

      [Token(Token = "0x600BD78")]
      [Address(RVA = "0x8543A0", Offset = "0x8531A0", VA = "0x108543A0", Slot = "8")]
      public override ContentNode Instantiate(ContentNode res) => (ContentNode) null;

      [Token(Token = "0x600BD79")]
      [Address(RVA = "0x8542F0", Offset = "0x8530F0", VA = "0x108542F0")]
      public void Add(RuneListWindow.RuneSource.ContentParam param)
      {
      }

      [Token(Token = "0x600BD7A")]
      [Address(RVA = "0x854730", Offset = "0x853530", VA = "0x10854730")]
      public void UpdateGameParameterAll()
      {
      }

      [Token(Token = "0x600BD7B")]
      [Address(RVA = "0x854700", Offset = "0x853500", VA = "0x10854700")]
      public void SetLockDisable(bool is_lock_disable)
      {
      }

      [Token(Token = "0x600BD7C")]
      [Address(RVA = "0x854470", Offset = "0x853270", VA = "0x10854470")]
      public void SelectTypeCurrent(bool is_force = false)
      {
      }

      [Token(Token = "0x600BD7D")]
      [Address(RVA = "0x8546B0", Offset = "0x8534B0", VA = "0x108546B0")]
      public void SelectType(int seteff_type, bool is_force = false)
      {
      }

      [Token(Token = "0x600BD7E")]
      [Address(RVA = "0x8546E0", Offset = "0x8534E0", VA = "0x108546E0")]
      public void SelectType(RuneSlotIndex slot_index, bool is_force = false)
      {
      }

      [Token(Token = "0x600BD7F")]
      [Address(RVA = "0x8544A0", Offset = "0x8532A0", VA = "0x108544A0")]
      public void SelectType(int seteff_type, RuneSlotIndex slot_index, bool is_force = false)
      {
      }

      [Token(Token = "0x600BD80")]
      [Address(RVA = "0x854860", Offset = "0x853660", VA = "0x10854860")]
      public RuneSource()
      {
      }

      [Token(Token = "0x20029B3")]
      public class ContentParam : ContentSource.Param
      {
        [Token(Token = "0x400CA2D")]
        [FieldOffset(Offset = "0x10")]
        private BindRuneData m_Rune;
        [Token(Token = "0x400CA2E")]
        [FieldOffset(Offset = "0x14")]
        private RuneListWindow.RuneNode m_Node;

        [Token(Token = "0x600BD81")]
        [Address(RVA = "0x596DE0", Offset = "0x595BE0", VA = "0x10596DE0", Slot = "6")]
        public override bool IsValid() => new bool();

        [Token(Token = "0x17001995")]
        public BindRuneData data
        {
          [Token(Token = "0x600BD82"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
          {
            return (BindRuneData) null;
          }
        }

        [Token(Token = "0x17001996")]
        public int runeType
        {
          [Token(Token = "0x600BD83"), Address(RVA = "0x83F4A0", Offset = "0x83E2A0", VA = "0x1083F4A0")] get
          {
            return new int();
          }
        }

        [Token(Token = "0x17001997")]
        public RuneSlotIndex runeSlotIndex
        {
          [Token(Token = "0x600BD84"), Address(RVA = "0x83F460", Offset = "0x83E260", VA = "0x1083F460")] get
          {
            return new RuneSlotIndex();
          }
        }

        [Token(Token = "0x600BD85")]
        [Address(RVA = "0x596EA0", Offset = "0x595CA0", VA = "0x10596EA0")]
        public ContentParam(BindRuneData rune)
        {
        }

        [Token(Token = "0x600BD86")]
        [Address(RVA = "0x83F2F0", Offset = "0x83E0F0", VA = "0x1083F2F0", Slot = "11")]
        public override void OnSetup(ContentNode node)
        {
        }

        [Token(Token = "0x600BD87")]
        [Address(RVA = "0x83F280", Offset = "0x83E080", VA = "0x1083F280")]
        public void GameParamUpdate()
        {
        }
      }
    }
  }
}
