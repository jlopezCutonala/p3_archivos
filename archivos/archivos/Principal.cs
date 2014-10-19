using System;

namespace archivos
{
	class Principal
	{
		public static void Main (string[] args)
		{
			//String[] contenido = new String[]{"linea1","linea2"};
			//Archivo archivo = new Archivo("ejemplo.txt");
			//archivo.leer();
			//archivo.escribir(contenido);
			//archivo.leer();
			
			Observador observador = new Observador();
			observador.inicia();
		}
	}
}

