<?php
defined('BASEPATH') OR exit('No direct script access allowed');

class MApotek extends CI_Model
{
    function AddData($tabel, $data=array())
    {
        $this->db->insert($tabel,$data);
        return $this->db->affected_rows();
    }

    function UpdateData($tabel, $where, $where_value, $data=array())
    {
        $this->db->update($tabel, $data, [$where => $where_value]);
        return $this->db->affected_rows();
    }

    function DeleteData($tabel, $where, $where_value)
    {
        $this->db->where($where, $where_value)->delete($tabel);
        return $this->db->affected_rows();
    }

    function GetData($tabel, $where = null, $value = null)
    {
        if($where === null && $value === null)
        {
            $query=$this->db->get($tabel);
            return $query;
        } else {
            $query= $this->db->get_where($tabel, [$where => $value]);
            return $query;
        }
    }  

    function check_login($table, $field1, $field2)
    {
        $this->db->select('*');
        $this->db->from($table);
        $this->db->where('username', $field1);
        $this->db->where('password', $field2);
        $this->db->limit(1);
        $query = $this->db->get();
        if ($query->num_rows() == 0) {
            return null;
        } else {
            return $query->result();
        }
    }
}