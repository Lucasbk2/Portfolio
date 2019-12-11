class Vagoes{
	public float cargaTotal;
	public float cargaAtual;
	public string materialCarga;
	public Vagoes(){
		this.cargaTotal =0f;
		this.cargaAtual = 0f;
		this.materialCarga = "Nenhum";
	}
	public Vagoes(float cT , float CA, string mC){
		this.cargaTotal = cT;
		this.cargaAtual = CA;
		this.materialCarga = mC;
	}
	public void setCargarAtual(float cargaAtual){
		this.cargaAtual = cargaAtual;
	}	
	public float getCargaAtual(){
		return cargaAtual;
	}
	public string getMaterialCarga(){
		return materialCarga;
	}

}