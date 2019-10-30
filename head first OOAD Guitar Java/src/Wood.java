
public enum Wood {
	INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY, MAPLE, COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA;
	public String toStroing() {
		switch(this) {
		case INDIAN_ROSEWOOD: return "indian rosewood";
		case BRAZILIAN_ROSEWOOD: return "brazilian rosewood";
		case MAHOGANY: return "mahogany";
		case MAPLE: return "maple";
		case COCOBOLO: return "cocobolo";
		case CEDAR: return "cedar";
		case ADIRONDACK: return "adirondack";
		case ALDER: return "alder";
		case SITKA: return "stika";
		default: return null;
		}
	}
}
