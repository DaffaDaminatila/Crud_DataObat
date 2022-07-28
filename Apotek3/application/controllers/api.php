<?php
header('Access-Control-Allow-Origin: *');
header("Access-Control-Allow-Methods: GET, OPTIONS");
defined('BASEPATH') OR exit('No direct script access allowed');

class api extends CI_Controller {
	function __construct(){
	parent::__construct();
	$this->load->model('MApotek');
	}

	public function index()
	{
        $status = array(
                'status' => 'Ok'
        );
		echo json_encode($status);
    }

    public function GetDataObat()
    {
        $query = $this->MApotek->GetData('obat')->result();
        echo json_encode($query);
    }

    public function PostObat()
    {
        $data = [
            'kode' => urldecode($this->uri->segment(3)),
            'supplier_id' => urldecode($this->uri->segment(4)),
            'nama_obat' => urldecode($this->uri->segment(5)),
            'produsen' => urldecode($this->uri->segment(6)),
            'stok' => urldecode($this->uri->segment(7)),
            'harga' => urldecode($this->uri->segment(8))
        ];
        $input = $this->MApotek->AddData('obat', $data);
        if ($input) {
            redirect('api');;
        } else {
            echo "Error";
        }
    }

    public function PutObat()
    {
        $kode = urldecode($this->uri->segment(3));
        $update['supplier_id'] = urldecode($this->uri->segment(4));
        $update['nama_obat'] = urldecode($this->uri->segment(5));
        $update['produsen'] = urldecode($this->uri->segment(6));
        $update['stok'] = urldecode($this->uri->segment(7));
        $update['harga'] = urldecode($this->uri->segment(8));
        $update = $this->MApotek->UpdateData('obat', 'kode', $kode, $update);
        if ($update) {
            redirect('api');
        } else {
            echo 'Error';
        }
    }

    public function DeleteObat()
    {
        $kode = urldecode($this->uri->segment(3));
        $delete = $this->MApotek->DeleteData('obat', 'kode', $kode);
        if ($delete) {
            redirect('api');
        } else {
            echo 'Error';
        }
    }

    public function GetDataSupplier()
    {
        $query = $this->MApotek->GetData('supplier')->result();
        echo json_encode($query);
    }

    public function GetDataTransaksi()
    {
        $query = $this->MApotek->GetData('transaksi')->result();
        echo json_encode($query);
    }

    public function GetDataAdmin()
    {
        $query = $this->MApotek->GetData('admin')->result();
        echo json_encode($query);
    }

    public function Login()
    {
        $username = urldecode($this->uri->segment(3));
        $password = urldecode($this->uri->segment(4));
        $query = $this->MApotek->check_login('admin', $username, $password);
        if ($query) {
            redirect('api');
        } else {
            $status = array(
                'status' => 'Error'
            );
        }
        echo json_encode($status);
    }
}
