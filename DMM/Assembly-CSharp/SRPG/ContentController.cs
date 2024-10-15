// Decompiled with JetBrains decompiler
// Type: SRPG.ContentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002256")]
  [ExecuteInEditMode]
  [AddComponentMenu("UI/ContentController")]
  public class ContentController : MonoBehaviour
  {
    [Token(Token = "0x400988E")]
    [FieldOffset(Offset = "0xC")]
    public bool m_WidthLoop;
    [Token(Token = "0x400988F")]
    [FieldOffset(Offset = "0xD")]
    public bool m_HeightLoop;
    [Token(Token = "0x4009890")]
    [FieldOffset(Offset = "0x10")]
    public ContentScroller m_Scroller;
    [Token(Token = "0x4009891")]
    [FieldOffset(Offset = "0x14")]
    public ContentNode m_Node;
    [Token(Token = "0x4009892")]
    [FieldOffset(Offset = "0x18")]
    public float m_PaddingLeft;
    [Token(Token = "0x4009893")]
    [FieldOffset(Offset = "0x1C")]
    public float m_PaddingRight;
    [Token(Token = "0x4009894")]
    [FieldOffset(Offset = "0x20")]
    public float m_PaddingTop;
    [Token(Token = "0x4009895")]
    [FieldOffset(Offset = "0x24")]
    public float m_PaddingBottom;
    [Token(Token = "0x4009896")]
    [FieldOffset(Offset = "0x28")]
    public Vector2 m_CellSize;
    [Token(Token = "0x4009897")]
    [FieldOffset(Offset = "0x30")]
    public Vector2 m_Spacing;
    [Token(Token = "0x4009898")]
    [FieldOffset(Offset = "0x38")]
    public ContentController.Constraint m_Constraint;
    [Token(Token = "0x4009899")]
    [FieldOffset(Offset = "0x3C")]
    public int m_ConstraintCount;
    [Token(Token = "0x400989A")]
    [FieldOffset(Offset = "0x40")]
    private RectTransform m_RectTransform;
    [Token(Token = "0x400989B")]
    [FieldOffset(Offset = "0x44")]
    private ContentSource m_Source;
    [Token(Token = "0x400989C")]
    [FieldOffset(Offset = "0x48")]
    private bool m_NodeStatic;
    [Token(Token = "0x400989D")]
    [FieldOffset(Offset = "0x4C")]
    private Dictionary<string, ContentNode> m_NodeUsed;
    [Token(Token = "0x400989E")]
    [FieldOffset(Offset = "0x50")]
    private List<ContentNode> m_NodeEmpty;
    [Token(Token = "0x400989F")]
    [FieldOffset(Offset = "0x54")]
    private Vector2 m_PageSize;
    [Token(Token = "0x40098A0")]
    [FieldOffset(Offset = "0x5C")]
    private int m_NodeWidthNum;
    [Token(Token = "0x40098A1")]
    [FieldOffset(Offset = "0x60")]
    private int m_NodeHeightNum;
    [Token(Token = "0x40098A2")]
    [FieldOffset(Offset = "0x64")]
    private int m_ViewWidthNum;
    [Token(Token = "0x40098A3")]
    [FieldOffset(Offset = "0x68")]
    private int m_ViewHeightNum;
    [Token(Token = "0x40098A4")]
    [FieldOffset(Offset = "0x6C")]
    private int m_SelectNode;
    [Token(Token = "0x40098A5")]
    [FieldOffset(Offset = "0x70")]
    private float m_MoveRefreshTime;
    [Token(Token = "0x40098A6")]
    [FieldOffset(Offset = "0x74")]
    private bool m_MoveRefresh;
    [Token(Token = "0x40098A7")]
    [FieldOffset(Offset = "0x78")]
    private object m_Work;
    [Token(Token = "0x40098A8")]
    [FieldOffset(Offset = "0x7C")]
    public Vector2 _test;

    [Token(Token = "0x1700148E")]
    public ContentScroller scroller
    {
      [Token(Token = "0x600926D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ContentScroller) null;
      }
    }

    [Token(Token = "0x1700148F")]
    public bool isScrollHorizontal
    {
      [Token(Token = "0x600926E"), Address(RVA = "0x55FF40", Offset = "0x55ED40", VA = "0x1055FF40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001490")]
    public bool isScrollVertical
    {
      [Token(Token = "0x600926F"), Address(RVA = "0x55FF60", Offset = "0x55ED60", VA = "0x1055FF60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001491")]
    public Vector2 anchoredPosition
    {
      [Token(Token = "0x6009270"), Address(RVA = "0x55FF80", Offset = "0x55ED80", VA = "0x1055FF80")] set
      {
      }
      [Token(Token = "0x6009271"), Address(RVA = "0x55FE80", Offset = "0x55EC80", VA = "0x1055FE80")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x17001492")]
    public int NodeWidthNum
    {
      [Token(Token = "0x6009272"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001493")]
    public int NodeHeightNum
    {
      [Token(Token = "0x6009273"), Address(RVA = "0x2B5EA0", Offset = "0x2B4CA0", VA = "0x102B5EA0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6009274")]
    [Address(RVA = "0x55D0A0", Offset = "0x55BEA0", VA = "0x1055D0A0", Slot = "4")]
    protected virtual void Awake()
    {
    }

    [Token(Token = "0x6009275")]
    [Address(RVA = "0x55F130", Offset = "0x55DF30", VA = "0x1055F130", Slot = "5")]
    public virtual void Initialize(ContentSource source, Vector2 pos)
    {
    }

    [Token(Token = "0x6009276")]
    [Address(RVA = "0x55EDD0", Offset = "0x55DBD0", VA = "0x1055EDD0")]
    private void InitializeParam()
    {
    }

    [Token(Token = "0x6009277")]
    [Address(RVA = "0x55E150", Offset = "0x55CF50", VA = "0x1055E150")]
    public void ForceUpdate()
    {
    }

    [Token(Token = "0x6009278")]
    [Address(RVA = "0x55F570", Offset = "0x55E370", VA = "0x1055F570", Slot = "6")]
    public virtual void Release()
    {
    }

    [Token(Token = "0x6009279")]
    [Address(RVA = "0x55FC80", Offset = "0x55EA80", VA = "0x1055FC80", Slot = "7")]
    protected virtual void Update()
    {
    }

    [Token(Token = "0x600927A")]
    [Address(RVA = "0x55F240", Offset = "0x55E040", VA = "0x1055F240")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x600927B")]
    [Address(RVA = "0x55F7B0", Offset = "0x55E5B0", VA = "0x1055F7B0")]
    private void UpdateNode()
    {
    }

    [Token(Token = "0x600927C")]
    [Address(RVA = "0x55F380", Offset = "0x55E180", VA = "0x1055F380")]
    public bool MoveRefresh() => new bool();

    [Token(Token = "0x600927D")]
    [Address(RVA = "0x55DC30", Offset = "0x55CA30", VA = "0x1055DC30")]
    public void CreateStaticNode(List<ContentNode> list)
    {
    }

    [Token(Token = "0x600927E")]
    [Address(RVA = "0x55D990", Offset = "0x55C790", VA = "0x1055D990")]
    public void CreateNode()
    {
    }

    [Token(Token = "0x600927F")]
    [Address(RVA = "0x55DE20", Offset = "0x55CC20", VA = "0x1055DE20")]
    public void DestroyNode()
    {
    }

    [Token(Token = "0x6009280")]
    [Address(RVA = "0x55D220", Offset = "0x55C020", VA = "0x1055D220")]
    private void CheckActiveNode()
    {
    }

    [Token(Token = "0x6009281")]
    [Address(RVA = "0x55EAE0", Offset = "0x55D8E0", VA = "0x1055EAE0")]
    private string GetNodeKey(int x, int y) => (string) null;

    [Token(Token = "0x6009282")]
    [Address(RVA = "0x55EB90", Offset = "0x55D990", VA = "0x1055EB90")]
    private ContentNode GetNodeUsed(int x, int y) => (ContentNode) null;

    [Token(Token = "0x6009283")]
    [Address(RVA = "0x55EA50", Offset = "0x55D850", VA = "0x1055EA50")]
    private ContentNode GetNodeEmpty() => (ContentNode) null;

    [Token(Token = "0x6009284")]
    [Address(RVA = "0x55E9F0", Offset = "0x55D7F0", VA = "0x1055E9F0")]
    public int GetNodeCount() => new int();

    [Token(Token = "0x6009285")]
    [Address(RVA = "0x55E7B0", Offset = "0x55D5B0", VA = "0x1055E7B0")]
    public List<ContentNode> GetNodeAll() => (List<ContentNode>) null;

    [Token(Token = "0x6009286")]
    [Address(RVA = "0x55E870", Offset = "0x55D670", VA = "0x1055E870")]
    public List<ContentNode> GetNodeChilds() => (List<ContentNode>) null;

    [Token(Token = "0x6009287")]
    [Address(RVA = "0x55ECB0", Offset = "0x55DAB0", VA = "0x1055ECB0")]
    public int GetParamIndex(int x, int y) => new int();

    [Token(Token = "0x6009288")]
    [Address(RVA = "0x55ED30", Offset = "0x55DB30", VA = "0x1055ED30")]
    public ContentSource.Param GetParam(int x, int y) => (ContentSource.Param) null;

    [Token(Token = "0x6009289")]
    [Address(RVA = "0x55ED70", Offset = "0x55DB70", VA = "0x1055ED70")]
    public ContentSource.Param GetParam(int index) => (ContentSource.Param) null;

    [Token(Token = "0x600928A")]
    [Address(RVA = "0x55E6C0", Offset = "0x55D4C0", VA = "0x1055E6C0")]
    public ContentGrid GetLastPageGrid() => new ContentGrid();

    [Token(Token = "0x600928B")]
    [Address(RVA = "0x55E4E0", Offset = "0x55D2E0", VA = "0x1055E4E0")]
    public ContentGrid GetGrid() => new ContentGrid();

    [Token(Token = "0x600928C")]
    [Address(RVA = "0x55E3D0", Offset = "0x55D1D0", VA = "0x1055E3D0")]
    public ContentGrid GetGrid(Vector2 pos) => new ContentGrid();

    [Token(Token = "0x600928D")]
    [Address(RVA = "0x55E390", Offset = "0x55D190", VA = "0x1055E390")]
    public ContentGrid GetGrid(int index) => new ContentGrid();

    [Token(Token = "0x600928E")]
    [Address(RVA = "0x55EC40", Offset = "0x55DA40", VA = "0x1055EC40")]
    public ContentGrid GetNormalizeGrid(int x, int y) => new ContentGrid();

    [Token(Token = "0x600928F")]
    [Address(RVA = "0x55EB30", Offset = "0x55D930", VA = "0x1055EB30")]
    public Vector2 GetNodePos(int x, int y) => new Vector2();

    [Token(Token = "0x6009290")]
    [Address(RVA = "0x55E650", Offset = "0x55D450", VA = "0x1055E650")]
    public Vector2 GetLastPageAnchorePos() => new Vector2();

    [Token(Token = "0x6009291")]
    [Address(RVA = "0x55E230", Offset = "0x55D030", VA = "0x1055E230")]
    public Vector2 GetAnchorePosFromGrid(int x, int y) => new Vector2();

    [Token(Token = "0x6009292")]
    [Address(RVA = "0x2790D0", Offset = "0x277ED0", VA = "0x102790D0")]
    public ContentNode GetNode(Vector2 screenPos) => (ContentNode) null;

    [Token(Token = "0x6009293")]
    [Address(RVA = "0x55F5C0", Offset = "0x55E3C0", VA = "0x1055F5C0")]
    public void Resize(int count = 0)
    {
    }

    [Token(Token = "0x6009294")]
    [Address(RVA = "0x55F740", Offset = "0x55E540", VA = "0x1055F740")]
    public void SetCurrentSource(ContentSource source)
    {
    }

    [Token(Token = "0x6009295")]
    [Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")]
    public ContentSource GetCurrentSource() => (ContentSource) null;

    [Token(Token = "0x6009296")]
    [Address(RVA = "0x550160", Offset = "0x54EF60", VA = "0x10550160")]
    public void SetWork(object value)
    {
    }

    [Token(Token = "0x6009297")]
    [Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")]
    public object GetWork() => (object) null;

    [Token(Token = "0x6009298")]
    [Address(RVA = "0x55F7A0", Offset = "0x55E5A0", VA = "0x1055F7A0")]
    public void SetSelect(int index)
    {
    }

    [Token(Token = "0x6009299")]
    [Address(RVA = "0x288AC0", Offset = "0x2878C0", VA = "0x10288AC0")]
    public int GetSelect() => new int();

    [Token(Token = "0x600929A")]
    [Address(RVA = "0x305850", Offset = "0x304650", VA = "0x10305850")]
    public void SetSpacing(Vector2 value)
    {
    }

    [Token(Token = "0x600929B")]
    [Address(RVA = "0x55EDA0", Offset = "0x55DBA0", VA = "0x1055EDA0")]
    public Vector2 GetSpacing() => new Vector2();

    [Token(Token = "0x600929C")]
    [Address(RVA = "0x55E2E0", Offset = "0x55D0E0", VA = "0x1055E2E0")]
    public Vector2 GetAnchorePos() => new Vector2();

    [Token(Token = "0x600929D")]
    [Address(RVA = "0x55FCB0", Offset = "0x55EAB0", VA = "0x1055FCB0")]
    public ContentController()
    {
    }

    [Token(Token = "0x2002257")]
    public enum Constraint
    {
      [Token(Token = "0x40098AA")] Flexible,
      [Token(Token = "0x40098AB")] FixedColumnCount,
      [Token(Token = "0x40098AC")] FixedRowCount,
    }
  }
}
