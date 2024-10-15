// Decompiled with JetBrains decompiler
// Type: SRPG.ContentNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002259")]
  [AddComponentMenu("UI/ContentNode")]
  public class ContentNode : MonoBehaviour
  {
    [Token(Token = "0x40098AF")]
    [FieldOffset(Offset = "0xC")]
    private RectTransform m_RectTransform;
    [Token(Token = "0x40098B0")]
    [FieldOffset(Offset = "0x10")]
    private ContentController m_ContentController;
    [Token(Token = "0x40098B1")]
    [FieldOffset(Offset = "0x14")]
    private int m_Index;
    [Token(Token = "0x40098B2")]
    [FieldOffset(Offset = "0x18")]
    private ContentSource.Param m_Param;
    [Token(Token = "0x40098B3")]
    [FieldOffset(Offset = "0x1C")]
    private ContentGrid m_Grid;
    [Token(Token = "0x40098B4")]
    [FieldOffset(Offset = "0x24")]
    private Vector2 m_Pos;
    [Token(Token = "0x40098B5")]
    [FieldOffset(Offset = "0x2C")]
    private bool m_ViewIn;

    [Token(Token = "0x17001497")]
    public RectTransform rectTransform
    {
      [Token(Token = "0x60092A5"), Address(RVA = "0x563150", Offset = "0x561F50", VA = "0x10563150")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17001498")]
    public ContentController contentController
    {
      [Token(Token = "0x60092A6"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (ContentController) null;
      }
    }

    [Token(Token = "0x17001499")]
    public int index
    {
      [Token(Token = "0x60092A7"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700149A")]
    public float sizeX
    {
      [Token(Token = "0x60092A8"), Address(RVA = "0x5631E0", Offset = "0x561FE0", VA = "0x105631E0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700149B")]
    public float sizeY
    {
      [Token(Token = "0x60092A9"), Address(RVA = "0x563220", Offset = "0x562020", VA = "0x10563220")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700149C")]
    public float posX
    {
      [Token(Token = "0x60092AA"), Address(RVA = "0x3A3940", Offset = "0x3A2740", VA = "0x103A3940")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700149D")]
    public float posY
    {
      [Token(Token = "0x60092AB"), Address(RVA = "0x2CD6D0", Offset = "0x2CC4D0", VA = "0x102CD6D0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x1700149E")]
    public int gridX
    {
      [Token(Token = "0x60092AC"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700149F")]
    public int gridY
    {
      [Token(Token = "0x60092AD"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x60092AE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60092AF")]
    [Address(RVA = "0x562900", Offset = "0x561700", VA = "0x10562900", Slot = "4")]
    public virtual void Initialize(ContentController controller)
    {
    }

    [Token(Token = "0x60092B0")]
    [Address(RVA = "0x562D90", Offset = "0x561B90", VA = "0x10562D90", Slot = "5")]
    public virtual void Release()
    {
    }

    [Token(Token = "0x60092B1")]
    [Address(RVA = "0x562700", Offset = "0x561500", VA = "0x10562700", Slot = "6")]
    public virtual void Copy(ContentNode src)
    {
    }

    [Token(Token = "0x60092B2")]
    [Address(RVA = "0x5630C0", Offset = "0x561EC0", VA = "0x105630C0", Slot = "7")]
    public virtual void Update()
    {
    }

    [Token(Token = "0x60092B3")]
    [Address(RVA = "0x562A80", Offset = "0x561880", VA = "0x10562A80", Slot = "8")]
    public virtual void LateUpdate()
    {
    }

    [Token(Token = "0x60092B4")]
    [Address(RVA = "0x562EB0", Offset = "0x561CB0", VA = "0x10562EB0", Slot = "9")]
    public virtual void Setup(int index, Vector2 pos, ContentSource.Param param)
    {
    }

    [Token(Token = "0x60092B5")]
    [Address(RVA = "0x562E60", Offset = "0x561C60", VA = "0x10562E60", Slot = "10")]
    public virtual void Setup(int index, int x, int y, ContentSource.Param param)
    {
    }

    [Token(Token = "0x60092B6")]
    [Address(RVA = "0x562DB0", Offset = "0x561BB0", VA = "0x10562DB0")]
    public void SetActive(bool value)
    {
    }

    [Token(Token = "0x60092B7")]
    [Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")]
    public void SetParam(ContentSource.Param param)
    {
    }

    [Token(Token = "0x60092B8")]
    [Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")]
    public ContentSource.Param GetParam() => (ContentSource.Param) null;

    [Token(Token = "0x60092B9")]
    public T GetParam<T>() where T : ContentSource.Param => (T) null;

    [Token(Token = "0x60092BA")]
    [Address(RVA = "0x562DE0", Offset = "0x561BE0", VA = "0x10562DE0")]
    public void SetGrid(int x, int y)
    {
    }

    [Token(Token = "0x60092BB")]
    [Address(RVA = "0x562E00", Offset = "0x561C00", VA = "0x10562E00")]
    public void SetGrid(ContentGrid grid)
    {
    }

    [Token(Token = "0x60092BC")]
    [Address(RVA = "0x562E20", Offset = "0x561C20", VA = "0x10562E20")]
    public void SetPos(float x, float y)
    {
    }

    [Token(Token = "0x60092BD")]
    [Address(RVA = "0x562E40", Offset = "0x561C40", VA = "0x10562E40")]
    public void SetPos(Vector2 pos)
    {
    }

    [Token(Token = "0x60092BE")]
    [Address(RVA = "0x562D00", Offset = "0x561B00", VA = "0x10562D00")]
    public Vector2 PosToLocalPos(Vector2 pos) => new Vector2();

    [Token(Token = "0x60092BF")]
    [Address(RVA = "0x562AB0", Offset = "0x5618B0", VA = "0x10562AB0")]
    public Vector2 LocalPosToPos(Vector2 pos) => new Vector2();

    [Token(Token = "0x60092C0")]
    [Address(RVA = "0x563040", Offset = "0x561E40", VA = "0x10563040")]
    public void UpdateLocalPos(Vector2 pos)
    {
    }

    [Token(Token = "0x60092C1")]
    [Address(RVA = "0x563000", Offset = "0x561E00", VA = "0x10563000")]
    public void UpdateAnchoredPos(Vector2 pos)
    {
    }

    [Token(Token = "0x60092C2")]
    [Address(RVA = "0x562810", Offset = "0x561610", VA = "0x10562810")]
    public Vector2 GetPivotAnchoredPosition(Vector2 pos) => new Vector2();

    [Token(Token = "0x60092C3")]
    [Address(RVA = "0x562760", Offset = "0x561560", VA = "0x10562760")]
    public Vector2 GetPivotAnchoredPosition() => new Vector2();

    [Token(Token = "0x60092C4")]
    [Address(RVA = "0x5628A0", Offset = "0x5616A0", VA = "0x105628A0")]
    public Vector2 GetWorldPos() => new Vector2();

    [Token(Token = "0x60092C5")]
    [Address(RVA = "0x562A50", Offset = "0x561850", VA = "0x10562A50")]
    public bool IsValid() => new bool();

    [Token(Token = "0x60092C6")]
    [Address(RVA = "0x5629C0", Offset = "0x5617C0", VA = "0x105629C0")]
    public bool IsInvalid() => new bool();

    [Token(Token = "0x60092C7")]
    [Address(RVA = "0x5629F0", Offset = "0x5617F0", VA = "0x105629F0")]
    public bool IsLock() => new bool();

    [Token(Token = "0x60092C8")]
    [Address(RVA = "0x562A20", Offset = "0x561820", VA = "0x10562A20")]
    public bool IsReMake() => new bool();

    [Token(Token = "0x60092C9")]
    [Address(RVA = "0x2C0B60", Offset = "0x2BF960", VA = "0x102C0B60")]
    public bool IsViewIn() => new bool();

    [Token(Token = "0x60092CA")]
    [Address(RVA = "0x34B860", Offset = "0x34A660", VA = "0x1034B860")]
    public bool IsViewOut() => new bool();

    [Token(Token = "0x60092CB")]
    [Address(RVA = "0x562BD0", Offset = "0x5619D0", VA = "0x10562BD0", Slot = "11")]
    public virtual void OnEnable()
    {
    }

    [Token(Token = "0x60092CC")]
    [Address(RVA = "0x562B70", Offset = "0x561970", VA = "0x10562B70", Slot = "12")]
    public virtual void OnDisable()
    {
    }

    [Token(Token = "0x60092CD")]
    [Address(RVA = "0x562CA0", Offset = "0x561AA0", VA = "0x10562CA0", Slot = "13")]
    public virtual void OnViewIn(Vector2 pivotViewPosition)
    {
    }

    [Token(Token = "0x60092CE")]
    [Address(RVA = "0x562CD0", Offset = "0x561AD0", VA = "0x10562CD0", Slot = "14")]
    public virtual void OnViewOut(Vector2 pivotViewPosition)
    {
    }

    [Token(Token = "0x60092CF")]
    [Address(RVA = "0x562C70", Offset = "0x561A70", VA = "0x10562C70", Slot = "15")]
    public virtual void OnSelectOn()
    {
    }

    [Token(Token = "0x60092D0")]
    [Address(RVA = "0x562C40", Offset = "0x561A40", VA = "0x10562C40", Slot = "16")]
    public virtual void OnSelectOff()
    {
    }

    [Token(Token = "0x60092D1")]
    [Address(RVA = "0x562B40", Offset = "0x561940", VA = "0x10562B40", Slot = "17")]
    public virtual void OnClick()
    {
    }

    [Token(Token = "0x60092D2")]
    [Address(RVA = "0x5630F0", Offset = "0x561EF0", VA = "0x105630F0")]
    public ContentNode()
    {
    }

    [Token(Token = "0x200225A")]
    public enum EventType
    {
      [Token(Token = "0x40098B7")] SETUP,
      [Token(Token = "0x40098B8")] ENABLE,
      [Token(Token = "0x40098B9")] DISABLE,
    }
  }
}
